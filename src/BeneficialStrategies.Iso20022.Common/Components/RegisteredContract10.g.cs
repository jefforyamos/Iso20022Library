﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContract10.  ISO2002 ID# _WJQ7IW49EeiU9cctagi5ow.
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
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_WJQ7IW49EeiU9cctagi5ow")]
[DisplayName("Registered Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContract10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContract10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContract10( System.String reqRegisteredContractAmendmentIdentification,System.String reqOriginalRegisteredContractIdentification,Priority2Code reqPriority,UnderlyingContract2Choice_ reqContract )
    {
        RegisteredContractAmendmentIdentification = reqRegisteredContractAmendmentIdentification;
        OriginalRegisteredContractIdentification = reqOriginalRegisteredContractIdentification;
        Priority = reqPriority;
        Contract = reqContract;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract amendment request.
    /// </summary>
    [IsoId("_WUJVYW49EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Amendment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdCtrctAmdmntId")]
    #endif
    [IsoXmlTag("RegdCtrctAmdmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RegisteredContractAmendmentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegisteredContractAmendmentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegisteredContractAmendmentIdentification { get; init; } 
    #else
    public System.String RegisteredContractAmendmentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original contract registration, as registered with the registration agent.
    /// </summary>
    [IsoId("_WUJVaW49EeiU9cctagi5ow")]
    [DisplayName("Original Registered Contract Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRegdCtrctId")]
    #endif
    [IsoXmlTag("OrgnlRegdCtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalRegisteredContractIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalRegisteredContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalRegisteredContractIdentification { get; init; } 
    #else
    public System.String OriginalRegisteredContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Priority requested for the amendment of the registered contract.
    /// </summary>
    [IsoId("_WUJVcW49EeiU9cctagi5ow")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Priority2Code Priority { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Priority2Code Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority2Code Priority { get; init; } 
    #else
    public Priority2Code Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Amendment details of the registered contract for the registered contract.
    /// </summary>
    [IsoId("_WUJVc249EeiU9cctagi5ow")]
    [DisplayName("Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrct")]
    #endif
    [IsoXmlTag("Ctrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingContract2Choice_ Contract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingContract2Choice_ Contract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingContract2Choice_ Contract { get; init; } 
    #else
    public UnderlyingContract2Choice_ Contract { get; set; } 
    #endif
    
    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_WUJVdW49EeiU9cctagi5ow")]
    [DisplayName("Contract Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctBal")]
    #endif
    [IsoXmlTag("CtrctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractBalance1? ContractBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractBalance1? ContractBalance { get; init; } 
    #else
    public ContractBalance1? ContractBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    [IsoId("_WUJVd249EeiU9cctagi5ow")]
    [DisplayName("Payment Schedule Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchdlTp")]
    #endif
    [IsoXmlTag("PmtSchdlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; } 
    #else
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; set; } 
    #endif
    
    /// <summary>
    /// Further additional information on the amendment.
    /// </summary>
    [IsoId("_WUJVeW49EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the contract registration amendment request.
    /// </summary>
    [IsoId("_WUJVe249EeiU9cctagi5ow")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation3? Attachment { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_WUJVfW49EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
