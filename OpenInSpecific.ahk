#SingleInstance Force

^+L::
{
    SoundBeep()
    
    SetTitleMatchMode "RegEx"
    
    if WinExist(".*__USER_PLUGIN__.*") {
        try {
            WinActivate ".*__USER_PLUGIN__.*"
            WinWaitActive ".*__USER_PLUGIN__.*", , 1  ; Wait up to 1 second for it to become active
        }
        catch {
            SoundBeep 1500, 500
            MsgBox "Could not activate window!", "Error", "Icon!"
        }
    }
    else {
        SoundBeep()
        SoundBeep()
    }
}