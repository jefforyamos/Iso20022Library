﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessedStatus3FormatChoice.  ISO2002 ID# _RnTTBNp-Ed-ak6NoX_4Aeg_1585305057.
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
    /// Choice of formats to express the processing status of an advice, a request or a movement.
    /// </summary>
    [KnownType(typeof(ProcessedStatus3FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus3FormatChoice.Proprietary))]
    [IsoId("_RnTTBNp-Ed-ak6NoX_4Aeg_1585305057")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processed Status 3 Format Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessedStatus3FormatChoice_
    #else
    public abstract partial class ProcessedStatus3FormatChoice_
    #endif
    {
    }
}
