﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingPosition2Choice.  ISO2002 ID# _QtevGtp-Ed-ak6NoX_4Aeg_-730269459.
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
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition2Choice.Code))]
    [KnownType(typeof(ProcessingPosition2Choice.Proprietary))]
    [IsoId("_QtevGtp-Ed-ak6NoX_4Aeg_-730269459")]
    [DisplayName("Processing Position 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingPosition2Choice_
    #else
    public abstract partial class ProcessingPosition2Choice_
    #endif
    {
    }
}
