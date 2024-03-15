﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstitutionIdentification9Choice.  ISO2002 ID# __IfgtbNIEeejueAciesPMA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Choice between formats for the identification ofa financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.ProprietaryIdentification))]
    [IsoId("__IfgtbNIEeejueAciesPMA")]
    [DisplayName("Financial Institution Identification 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification9Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification9Choice_
    #endif
    {
    }
}
