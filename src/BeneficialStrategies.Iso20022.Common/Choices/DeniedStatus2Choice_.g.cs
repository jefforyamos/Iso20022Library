﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DeniedStatus2Choice.  ISO2002 ID# _UUc1xNp-Ed-ak6NoX_4Aeg_1894682971.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus2Choice.Reason))]
    [IsoId("_UUc1xNp-Ed-ak6NoX_4Aeg_1894682971")]
    [DisplayName("Denied Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeniedStatus2Choice_
    #else
    public abstract partial class DeniedStatus2Choice_
    #endif
    {
    }
}
