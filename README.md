# PictureDownTool
1、选择数据文件可以选择文本文件和Excel文件，如果是Excel文件数据必须是在第一个Sheet的第一列	<br />
2、选择图片生成图片的文件夹，文件夹必须是空文件夹<br />
3、线程个数，下载的数据个数非常大的话可以用20的多线程，如果出现问题就选择小的
4、所有信息提示都会体现在“下载按钮”下边的大文本框中<br /><br />
5、文件名称分隔符，是创建文件名称的，例如：<br />
	a、https://mobilecodec.alipay.com/show.htm?code=cpx03418se3dcdgzs2oru28，应该填写“=”，文件名称为：cpx03418se3dcdgzs2oru28.png
	b、https://mobilecodec.alipay.com/cpx03418se3dcdgzs2oru28 应该填写“/”文件名称为cpx03418se3dcdgzs2oru28.png  
6、 分隔符不为空时检查数据有效性是以是否存在“文件名称分隔符”来判断的，如果连接中没有“文件名称分隔符”则不会下载<br />
7、如果选择的文件是Excel，则Excel参数必填计数从0开始<br />
