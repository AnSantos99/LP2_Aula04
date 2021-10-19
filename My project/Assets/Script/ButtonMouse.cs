using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMouse : CustomYieldInstruction
{
    public override bool keepWaiting => !Input.anyKey;
}
