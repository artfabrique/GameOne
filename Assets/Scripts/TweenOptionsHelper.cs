using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core;
using System.Reflection;
using System;

namespace Startle.Helpers
{
    public class TweenOptionsHelper
    {
        private Tween _aotTween;
        private Tweener _aotTweener;

        public void SetTweenOptions(Tween tween, float delay, Ease easing, LoopType loopType, int loops, out Tween tweenOut)
        {
            tweenOut = tween;
            tweenOut.SetEase(easing).SetLoops(loops, loopType).SetDelay(delay);
        }
        public void SetCurveEase(Tween tween, AnimationCurve curve, out Tween tweenOut, out TweenParams tweenParams)
        {
            tweenOut = tween;
            tweenParams = new TweenParams().SetEase(curve);
            tweenOut.SetAs(tweenParams);
        }
        public void SetAutoKill(Tween tween, bool autoKill, out Tween tweenOut)
        {
            tweenOut = tween;
            tweenOut.SetAutoKill(autoKill);
        }
    }
}
