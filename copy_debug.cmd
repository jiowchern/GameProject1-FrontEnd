rd Assets\Project\Plugins\Backend /q /s
mkdir Assets\Project\Plugins\Backend

rem copy ..\ItIsNotAGame-Backend\Game\bin\Debug\ Assets\Project\Plugins\Backend
copy ..\ItIsNotAGame-Backend\Data\bin\Debug\*.* Assets\Project\Plugins\Backend
copy ..\ItIsNotAGame-Backend\PlayUser\bin\Debug\*.* Assets\Project\Plugins\Backend
rem copy ..\ItIsNotAGame-Backend\PlayUser\bin\Debug\*.* Assets\Project\Plugins\Backend



rd Assets\Project\RemotingCode\ /q /s
mkdir Assets\Project\RemotingCode

xcopy ..\ItIsNotAGame-Backend\Game\*.cs Assets\Project\RemotingCode /s 



pause