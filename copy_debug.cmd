rd Assets\Project\Plugins\Backend /q /s
mkdir Assets\Project\Plugins\Backend

rem copy ..\ItIsNotAGame1-Backend\Game\bin\Debug\ Assets\Project\Plugins\Backend
copy ..\ItIsNotAGame1-Backend\Data\bin\Debug\*.* Assets\Project\Plugins\Backend
copy ..\ItIsNotAGame1-Backend\PlayUser\bin\Debug\*.* Assets\Project\Plugins\Backend
rem copy ..\ItIsNotAGame1-Backend\PlayUser\bin\Debug\*.* Assets\Project\Plugins\Backend



rd Assets\Project\RemotingCode\ /q /s
mkdir Assets\Project\RemotingCode

xcopy ..\ItIsNotAGame1-Backend\Game\*.cs Assets\Project\RemotingCode /s 



pause