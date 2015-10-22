﻿// Copyright (c) DNN Software. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using DnnLocalization = DotNetNuke.Services.Localization.Localization;

namespace Dnn.DynamicContent.Exceptions
{
    public class DataTypeInUseException : EntityInUseException
    {
        public DataTypeInUseException(DataType dataType)
            : base(DnnLocalization.GetString("DataType",
                DnnLocalization.SharedResourceFile), dataType.DataTypeId)            
        {
        }
    }
}
