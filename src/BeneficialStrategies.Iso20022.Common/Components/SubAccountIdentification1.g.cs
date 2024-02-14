﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification1.  ISO2002 ID# _VbFGp9p-Ed-ak6NoX_4Aeg_1318763778.
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
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_VbFGp9p-Ed-ak6NoX_4Aeg_1318763778")]
[DisplayName("Sub Account Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubAccountIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubAccountIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubAccountIdentification1( AccountIdentificationFormatChoice_ reqIdentification,System.String reqFungibleIndicator,System.String reqActivityIndicator )
    {
        Identification = reqIdentification;
        FungibleIndicator = reqFungibleIndicator;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_VbFGqNp-Ed-ak6NoX_4Aeg_1744528436")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentificationFormatChoice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentificationFormatChoice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationFormatChoice_ Identification { get; init; } 
    #else
    public AccountIdentificationFormatChoice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities in the account are fungible, ie, interchangeable.
    /// </summary>
    [IsoId("_VbO3oNp-Ed-ak6NoX_4Aeg_1744529409")]
    [DisplayName("Fungible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FngbInd")]
    #endif
    [IsoXmlTag("FngbInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator FungibleIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FungibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FungibleIndicator { get; init; } 
    #else
    public System.String FungibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    [IsoId("_VbO3odp-Ed-ak6NoX_4Aeg_-2139469577")]
    [DisplayName("Activity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyInd")]
    #endif
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ActivityIndicator { get; init; } 
    #else
    public System.String ActivityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_VbO3otp-Ed-ak6NoX_4Aeg_-1134985221")]
    [DisplayName("Balance For Sub Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForSubAcct")]
    #endif
    [IsoXmlTag("BalForSubAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalanceInformation1? BalanceForSubAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalanceInformation1? BalanceForSubAccount { get; init; } 
    #else
    public AggregateBalanceInformation1? BalanceForSubAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
