﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitCriteria6.  ISO2002 ID# _FMyWZ24-EeiU9cctagi5ow.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the limit information and the expected limit report. A name may be given to the new query.
/// </summary>
[IsoId("_FMyWZ24-EeiU9cctagi5ow")]
[DisplayName("Limit Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitCriteria6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_FZ5lV24-EeiU9cctagi5ow")]
    [DisplayName("New Query Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewQryNm")]
    #endif
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NewQueryName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewQueryName { get; init; } 
    #else
    public System.String? NewQueryName { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria to extract the limit information.
    /// </summary>
    [IsoId("_FZ5lWW4-EeiU9cctagi5ow")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LimitSearchCriteria6? SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitSearchCriteria6? SearchCriteria { get; init; } 
    #else
    public LimitSearchCriteria6? SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the expected limit report.
    /// </summary>
    [IsoId("_FZ5lW24-EeiU9cctagi5ow")]
    [DisplayName("Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrCrit")]
    #endif
    [IsoXmlTag("RtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LimitReturnCriteria2? ReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitReturnCriteria2? ReturnCriteria { get; init; } 
    #else
    public LimitReturnCriteria2? ReturnCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
