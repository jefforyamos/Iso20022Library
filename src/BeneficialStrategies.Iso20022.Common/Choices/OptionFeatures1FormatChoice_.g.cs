﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OptionFeatures1FormatChoice.  ISO2002 ID# _Rm2nFdp-Ed-ak6NoX_4Aeg_741252058.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the feature of an option.
    /// </summary>
    [KnownType(typeof(OptionFeatures1FormatChoice.Code))]
    [KnownType(typeof(OptionFeatures1FormatChoice.Proprietary))]
    [IsoId("_Rm2nFdp-Ed-ak6NoX_4Aeg_741252058")]
    [DisplayName("Option Features 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionFeatures1FormatChoice_
    #else
    public abstract partial class OptionFeatures1FormatChoice_
    #endif
    {
    }
}
