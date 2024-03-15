﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OrganisationIdentificationSchemeName1Choice.  ISO2002 ID# _QACaQtp-Ed-ak6NoX_4Aeg_362604391.
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
    /// Sets of elements to identify a name of the organisation identification scheme.
    /// </summary>
    [KnownType(typeof(OrganisationIdentificationSchemeName1Choice.Code))]
    [KnownType(typeof(OrganisationIdentificationSchemeName1Choice.Proprietary))]
    [IsoId("_QACaQtp-Ed-ak6NoX_4Aeg_362604391")]
    [DisplayName("Organisation Identification Scheme Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrganisationIdentificationSchemeName1Choice_
    #else
    public abstract partial class OrganisationIdentificationSchemeName1Choice_
    #endif
    {
    }
}
