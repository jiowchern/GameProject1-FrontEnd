rd Assets\Project\Plugins\Backend /q /s
mkdir Assets\Project\Plugins\Backend

copy ..\Backend\Game\bin\Release\RegulusBehaviourTree.dll Assets\Project\Plugins\Backend
copy ..\Backend\Data\bin\Release\*.dll Assets\Project\Plugins\Backend
copy ..\Backend\PlayUser\bin\Release\*.dll Assets\Project\Plugins\Backend




rd Assets\Project\RemotingCode\ /q /s
mkdir Assets\Project\RemotingCode

xcopy ..\Backend\Game\*.cs Assets\Project\RemotingCode /s 

copy ThirdParty\Protobuf\*.dll Assets\Project\Plugins\Backend

pause