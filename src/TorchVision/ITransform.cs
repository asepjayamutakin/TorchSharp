// Copyright (c) .NET Foundation and Contributors.  All Rights Reserved.  See LICENSE in the project root for license information.

using static TorchSharp.torch;

namespace TorchSharp
{
    public static partial class torchvision
    {
        public interface ITransform
        {
            Tensor call(Tensor input);
        }
    }
}
