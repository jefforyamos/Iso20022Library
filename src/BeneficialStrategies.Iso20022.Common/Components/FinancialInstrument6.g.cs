﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument6.  ISO2002 ID# _VHQywtp-Ed-ak6NoX_4Aeg_935715973.
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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_VHQywtp-Ed-ak6NoX_4Aeg_935715973")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Instrument")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument6( SecurityIdentification1Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_VHQyw9p-Ed-ak6NoX_4Aeg_935715975")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification1Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification1Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification1Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification1Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_VHQyxNp-Ed-ak6NoX_4Aeg_935716215")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_VHQyxdp-Ed-ak6NoX_4Aeg_935716232")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SupplementaryIdentification { get; init; } 
    #else
    public System.String? SupplementaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, 'Class A', 'Class 2'.
    /// </summary>
    [IsoId("_VHQyxtp-Ed-ak6NoX_4Aeg_935716285")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Class Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassType { get; init; } 
    #else
    public System.String? ClassType { get; set; } 
    #endif
    
    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_VHQyx9p-Ed-ak6NoX_4Aeg_935716267")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Form")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #else
    public FormOfSecurity1Code? SecuritiesForm { get; set; } 
    #endif
    
    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_VHQyyNp-Ed-ak6NoX_4Aeg_935716311")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Distribution Policy")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #else
    public DistributionPolicy1Code? DistributionPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_VHQyydp-Ed-ak6NoX_4Aeg_1843918691")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product Group")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ProductGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductGroup { get; init; } 
    #else
    public System.String? ProductGroup { get; set; } 
    #endif
    
    
    #nullable disable
    
}
