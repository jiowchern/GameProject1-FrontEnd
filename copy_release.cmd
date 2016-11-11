rd Assets\Project\Plugins\Backend /q /s
mkdir Assets\Project\Plugins\Backend

copy ..\ItIsNotAGame1-Backend\Game\bin\Release\RegulusBehaviourTree.dll Assets\Project\Plugins\Backend
copy ..\ItIsNotAGame1-Backend\Data\bin\Release\*.dll Assets\Project\Plugins\Backend
copy ..\ItIsNotAGame1-Backend\PlayUser\bin\Release\*.dll Assets\Project\Plugins\Backend




rd Assets\Project\RemotingCode\ /q /s
mkdir Assets\Project\RemotingCode

xcopy ..\ItIsNotAGame1-Backend\Game\*.cs Assets\Project\RemotingCode /s 

copy ThirdParty\Protobuf\*.dll Assets\Project\Plugins\Backend

pause