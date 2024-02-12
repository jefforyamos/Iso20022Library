﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IndividualPersonIdentificationChoice.  ISO2002 ID# _REuxfNp-Ed-ak6NoX_4Aeg_-925696504.
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
    /// Choice of identification of an individual person.
    /// </summary>
    [KnownType(typeof(IndividualPersonIdentificationChoice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentificationChoice.PersonName))]
    [IsoId("_REuxfNp-Ed-ak6NoX_4Aeg_-925696504")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Individual Person Identification Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndividualPersonIdentificationChoice_
    #else
    public abstract partial class IndividualPersonIdentificationChoice_
    #endif
    {
    }
}
