function ISARtest(i1,i2,r1,r2,thre)   % %��ʼ��0 3 %������۽�15 12 %��ֵ0.2
    % ISAR.m
    %------------------------------------------------------------------------
    %��ȡ�������ݽ��г������ԱȲ�ͬ�������ֱ��ʺͱ�����ȡ
    % ���з�ʽ��
    %   ��ISAR.m�ļ���GTRIdata_read.m��ȡ�����ļ���f101hh360.dat�����ļ�����һ�����м���
    %------------------------------------------------------------------------
    load T72HH360.mat;
%     cf = 9.6;
%     degstep = 0.05;     %
%     frqstep = 3;        %
    %[na,nf,cf,frqstep,degstep,dangle,r0,y] = GTRIdata_read('f101hh360.dat');

    %������ʼ���������۽�
   % [V11,V12,V2] = ThetaChange(15,5,30,14,sig);
    cf = 9.6;
    degstep = 0.05;     %

   %  i1 = 0;  %��ʼ��
    % i2 = 3;
    % r1 = 15;  %������۽�
   %  r2 = 12;
    lamda = 0.300000/cf;
    delta1 = (180*lamda)/(2*pi*r1);  %�������ֱ���
    delta2 = (180*lamda)/(2*pi*r2);
    V11 = sig((i1/degstep+1):((i1+r1)/degstep),:);  %��ȡ�������ݽ��д���    0-300
    V12 = sig((i2/degstep+1):((i2+r1)/degstep),:);    %61-360
    V2 = sig((i1/degstep+1):((i1+r2)/degstep),:);     %1-240
    %��ʼ�� 0��3   ������۽��� 15��12


    %------------------------------������---------------------------------%
    v11 = ifft2(V11);  %��FFT����
    v11 = fftshift(v11);
    v12 = ifft2(V12);
    v12 = fftshift(v12);
    v2 = ifft2(V2);
    v2 = fftshift(v2);  

    %-----------------------------������ȡ---------------------------------%
    %----------------����һ Ƶ���򱳾���ȡ----------------%
    B1 = mean(sig(220:360,:),1);  %ȡ7��ľ�ֵ��Ϊ����

    %----------------������ ͼ���򱳾���ȡ----------------%
  % thre = 0.1;     %��������
   % B2 = threshold(v11,v12,thre);
    B2 = zeros(size(v11,1),size(v11,2));
    for i =1:size(v11,1)
        for j = 1:size(v11,2)
            if abs(v11(i,j)-v12(i,j)) < thre  %��������
                B2(i,j) = v11(i,j);
            else B2(i,j) = 0;
            end
        end
    end

    %-----------------------------��������---------------------------------%
    S1 = bsxfun(@minus,V11,B1);%��
    s1 = ifft2(S1);
    s1 = fftshift(s1);
    s2 = v11-B2;

    %-------------------------ת����������ͼ��---------------------------%
    max1 = max(max(v11));
    ima1 = abs(v11);
    ima1 = ima1./abs(max1);
    ima1 = 20*log10(ima1);
    for i = 1:size(ima1,1)
        for j = 1:size(ima1,2)
            if ima1(i,j) < -48
                ima1(i,j) = -50;
            end
        end
    end
    figure();
    imagesc(ima1,[-50 0]);
    colormap jet;
    colorbar;
    title(['������ȡ-������۽�',num2str(r1-i1+1),'��']);
    xlabel('������');
    ylabel('��λ��');

    max2 = max(max(v2));
    ima2 = abs(v2);
    ima2 = ima2./max2;
    ima2 = 20*log10(ima2);
    for i = 1:size(ima2,1)
        for j = 1:size(ima2,2)
            if ima2(i,j) < -48
                ima2(i,j) = -50;
            end
        end
    end
    figure();
    imagesc(-abs(ima2),[-50 0]);
    colormap jet;
    colorbar;
    title(['������ȡ-������۽�',num2str(r2-i2+1),'��']);
    xlabel('������');
    ylabel('��λ��');

    max4 = max(max(v11));
    ima4 = abs(s1);
    ima4 = ima4./abs(max4);
    ima4 = 20*log10(ima4);
    for i = 1:size(ima4,1)
        for j = 1:size(ima4,2)
            if ima4(i,j) < -48
                ima4(i,j) = -50;
            end
        end
    end
    figure();
    imagesc(ima4,[-50 0]);
    colormap jet;
    colorbar;
    title('Ƶ���򱳾�����');
    xlabel('������');
    ylabel('��λ��');

    max5 = max(max(v11));
    ima5 = abs(s2);
    ima5 = ima5./abs(max5);
    ima5 = 20*log10(ima5);
    for i = 1:size(ima5,1)
        for j = 1:size(ima5,2)
            if ima5(i,j) < -48
                ima5(i,j) = -50;
            end
        end
    end
    %ima5_plus =rgb2gray(ima5);
    figure();
    imagesc(ima5,[-50 0]);
    colormap jet;
    colorbar;
    title('ͼ���򱳾�����');
    xlabel('������');
    ylabel('��λ��');
end