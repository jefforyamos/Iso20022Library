﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstitutionIdentification8Choice.  ISO2002 ID# _M0nFYTfAEeaijYcl4fyXoQ.
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
    /// Choice between formats for the identification of the financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.ProprietaryIdentification))]
    [IsoId("_M0nFYTfAEeaijYcl4fyXoQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Institution Identification 8 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification8Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification8Choice_
    #endif
    {
    }
}
