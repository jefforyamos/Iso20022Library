﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceReport3.  ISO2002 ID# _brky0RmCEeKxsrht2duUcg.
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
/// Information about a price report.
/// </summary>
[IsoId("_brky0RmCEeKxsrht2duUcg")]
[DisplayName("Price Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceReport3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_cAvKhRmCEeKxsrht2duUcg")]
    [DisplayName("Price Valuation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricValtnDtls")]
    #endif
    [IsoXmlTag("PricValtnDtls")]
    public PriceValuation4? PriceValuationDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _cAvKhRmCEeKxsrht2duUcg
    
    
    #nullable disable
    
}
