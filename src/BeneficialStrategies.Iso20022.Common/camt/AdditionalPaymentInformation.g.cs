﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AdditionalPaymentInformation.  ISO2002 ID# _FNvJVtE-Ed-BzquC8wXy7w_-95467495.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.028.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Additional Payment Information message is sent by an account servicing institution to an account owner.
/// This message is used to provide additional or corrected information on a payment instruction or statement entry, in order to allow reconciliation.
/// Usage
/// The Additional Payment Information message provides elements which are usually not reported in a statement or advice (such as full remittance information or identification of parties other than the account servicing institution and the account owner.) It complements information about a payment instruction that has already been received, in the form of one or several entries of the original payment instruction.
/// The Additional Payment Information message covers one and only one original payment instruction. If several payment instructions need further details, multiple Additional Payment Information messages must be used, one for each of the payment instructions.
/// The AdditionalPaymentInformation message may be used as a result of two investigation processes and in a way outlined below.
/// - A Claim Non Receipt workflow raised by the creditor or recipient of the payment: This means that the payment instruction has reached the creditor or beneficiary. The account owner needs further details or correct information for its reconciliation processes. The Additional Payment Information can be used to provide the missing information.
/// - A Request To Modify Payment workflow raised by the debtor or one of the intermediate agents upstream: When the payment instruction has reached its intended recipient and the modification does not affect the accounting at the account servicing institution, this Additional Payment Information message allows the account owner to receive further particulars or correct information about a payment instruction or an entry passed to its account.
/// The Additional Payment Information message cannot be used to trigger a request for modification of a payment instruction activity. A Request To Modify Payment message must be used. In other words, if a debtor or one of intermediate agent (excluding the account servicing institution of the creditor) realises the some information was missing in the original payment instruction, he should not use an Additional Payment Information but instead a Request To Modify Payment message.
/// It is assumed that when an account servicing institution sends out an Additional Payment Information message, the institution is fairly confident that this will resolve the case. Therefore it does not need to wait for a Resolution Of Investigation message. Neither does the account owner, or whoever receives the additional information, need to send back a Resolution Of Investigation message. Positive resolution in this case is implicit. Both parties are expected to close the case. In the event that the problem does not go away, a party can re-open the case.
/// </summary>
[Description(@"Scope|The Additional Payment Information message is sent by an account servicing institution to an account owner.|This message is used to provide additional or corrected information on a payment instruction or statement entry, in order to allow reconciliation.|Usage|The Additional Payment Information message provides elements which are usually not reported in a statement or advice (such as full remittance information or identification of parties other than the account servicing institution and the account owner.) It complements information about a payment instruction that has already been received, in the form of one or several entries of the original payment instruction.|The Additional Payment Information message covers one and only one original payment instruction. If several payment instructions need further details, multiple Additional Payment Information messages must be used, one for each of the payment instructions.|The AdditionalPaymentInformation message may be used as a result of two investigation processes and in a way outlined below.|- A Claim Non Receipt workflow raised by the creditor or recipient of the payment: This means that the payment instruction has reached the creditor or beneficiary. The account owner needs further details or correct information for its reconciliation processes. The Additional Payment Information can be used to provide the missing information.|- A Request To Modify Payment workflow raised by the debtor or one of the intermediate agents upstream: When the payment instruction has reached its intended recipient and the modification does not affect the accounting at the account servicing institution, this Additional Payment Information message allows the account owner to receive further particulars or correct information about a payment instruction or an entry passed to its account.|The Additional Payment Information message cannot be used to trigger a request for modification of a payment instruction activity. A Request To Modify Payment message must be used. In other words, if a debtor or one of intermediate agent (excluding the account servicing institution of the creditor) realises the some information was missing in the original payment instruction, he should not use an Additional Payment Information but instead a Request To Modify Payment message.|It is assumed that when an account servicing institution sends out an Additional Payment Information message, the institution is fairly confident that this will resolve the case. Therefore it does not need to wait for a Resolution Of Investigation message. Neither does the account owner, or whoever receives the additional information, need to send back a Resolution Of Investigation message. Positive resolution in this case is implicit. Both parties are expected to close the case. In the event that the problem does not go away, a party can re-open the case.")]
[IsoId("_FNvJVtE-Ed-BzquC8wXy7w_-95467495")]
[DisplayName("Additional Payment Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalPaymentInformation : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.028.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.028.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.028.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalPaymentInformation instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalPaymentInformation( CaseAssignment reqAssignment,Case reqCase,PaymentInstructionExtract reqUnderlying,PaymentComplementaryInformation reqInformation )
    {
        Assignment = reqAssignment;
        Case = reqCase;
        Underlying = reqUnderlying;
        Information = reqInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment.
    /// </summary>
    [IsoId("_FNvJV9E-Ed-BzquC8wXy7w_1337484755")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseAssignment Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment Assignment { get; init; } 
    #else
    public CaseAssignment Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_FNvJWNE-Ed-BzquC8wXy7w_1326400714")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Case Case { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Case Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case Case { get; init; } 
    #else
    public Case Case { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the underlying payment instruction.
    /// </summary>
    [IsoId("_FNvJWdE-Ed-BzquC8wXy7w_1723515214")]
    [DisplayName("Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Undrlyg")]
    #endif
    [IsoXmlTag("Undrlyg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentInstructionExtract Underlying { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentInstructionExtract Underlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstructionExtract Underlying { get; init; } 
    #else
    public PaymentInstructionExtract Underlying { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to the underlying payment instruction.
    /// </summary>
    [IsoId("_FNvJWtE-Ed-BzquC8wXy7w_-1310325832")]
    [DisplayName("Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Inf")]
    #endif
    [IsoXmlTag("Inf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentComplementaryInformation Information { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentComplementaryInformation Information { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentComplementaryInformation Information { get; init; } 
    #else
    public PaymentComplementaryInformation Information { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AdditionalPaymentInformationDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AdditionalPaymentInformation.

