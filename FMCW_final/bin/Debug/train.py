import sys
sys.path.append(r"D:/Python3.5/Lib")
sys.path.append(r"D:/Python3.5/Lib/site-packages/tensorflow/__init__.py")

import tensorflow as tf
import numpy as np

######################################################################
train_image = []
for i in range(1, 21):
    train_image.append(np.loadtxt('./data/data/H/H'+str(i)+'.txt').reshape(3840))
for i in range(1, 21):
    train_image.append(np.loadtxt('./data/data/D/data'+str(i)+'.txt').reshape(3840))
for i in range(1, 21):
    train_image.append(np.loadtxt('./data/data/Q/Q' + str(i) + '.txt').reshape(3840))
print(np.shape(train_image))
train_label = []
for i in range(1, 21):
    train_label.append([1., 0., 0., 0.])
for i in range(21, 41):
    train_label.append([0., 1., 0., 0.])
for i in range(41, 61):
    train_label.append([0., 0., 1., 0.])
print(np.shape(train_label))
test_image = []
for i in range(21, 31):
    test_image.append(np.loadtxt('./data/data/H/H'+str(i)+'.txt').reshape(3840))
for i in range(21, 31):
    test_image.append(np.loadtxt('./data/data/D/data'+str(i)+'.txt').reshape(3840))
for i in range(21, 31):
    test_image.append(np.loadtxt('./data/data/Q/Q' + str(i) + '.txt').reshape(3840))
print(np.shape(test_image))
test_label = []
for i in range(1, 11):
    test_label.append([1., 0., 0., 0.])
for i in range(11, 21):
    test_label.append([0., 1., 0., 0.])
for i in range(21, 31):
    test_label.append([0., 0., 1., 0.])
print(np.shape(test_label))
for x in train_image:
    x=x*10
for x in test_image:
    x=x*10


######################################################################
def next_batch(num, data1,data2):
    """
    Return a total of `num` samples from the array `data`.
    """
    idx = np.arange(0, len(data1))  # get all possible indexes
    np.random.shuffle(idx)  # shuffle indexes
    idx = idx[0:num]  # use only `num` random indexes
    data_shuffle1 = [data1[i] for i in idx]  # get list of `num` random samples
    data_shuffle1 = np.asarray(data_shuffle1)  # get back numpy array
    data_shuffle2 = [data2[i] for i in idx]  # get list of `num` random samples
    data_shuffle2 = np.asarray(data_shuffle2)  # get back numpy array

    return data_shuffle1, data_shuffle2
######################################################################
x = tf.placeholder(tf.float32,[None,3840])
W = tf.Variable(tf.zeros([3840, 4]))
b = tf.Variable(tf.zeros([4]))
y = tf.nn.softmax(tf.matmul(x,W)+b)
y_ = tf.placeholder(tf.float32,[None,4])
cross_entropy = tf.reduce_mean(tf.nn.softmax_cross_entropy_with_logits(labels=y_, logits=y))
train_step = tf.train.GradientDescentOptimizer(0.01).minimize(cross_entropy)
sess = tf.InteractiveSession()
tf.global_variables_initializer().run()
print(sess.run(b))
for _ in range(1000):
    batch_xs,batch_ys= next_batch(16, train_image,train_label)
    sess.run(train_step, feed_dict={x: batch_xs, y_: batch_ys})
correct_prediction = tf.equal(tf.argmax(y,1),tf.arg_max(y_,1))
accuracy = tf.reduce_mean(tf.cast(correct_prediction, tf.float32))
print(sess.run(accuracy,feed_dict={x: test_image,y_: test_label}))
print(sess.run(b))
print(sess.run(y,feed_dict={x: test_image}))
# saver = tf.train.Saver()
# save_path = saver.save(sess, "./model/model1.ckpt")
# print("Save to path: ", save_path)
