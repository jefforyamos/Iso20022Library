﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstitutionIdentification10Choice.  ISO2002 ID# _RY0JwWAZEeiH9-hkDDXUHA.
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
    /// Choice between formats for the identification of a financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification10Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification10Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification10Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification10Choice.ProprietaryIdentification))]
    [IsoId("_RY0JwWAZEeiH9-hkDDXUHA")]
    [DisplayName("Financial Institution Identification 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification10Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification10Choice_
    #endif
    {
    }
}
