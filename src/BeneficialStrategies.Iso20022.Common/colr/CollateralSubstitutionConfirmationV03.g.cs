﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralSubstitutionConfirmationV03.  ISO2002 ID# _7A0N0WNmEeSIWbZ6by9dnA.
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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.012.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This CollateralSubstitutionConfirmation message is sent by:
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager.
/// This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released. In the event that multiple pieces of collateral are being delivered in place of the collateral due to be returned by the giver, this message should only be generated once all collateral pieces have been agreed between both parties. Then the taker confirms that the collateral substitution (that is all pieces have been received) and acknowledges return of collateral.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released.
/// </summary>
[Description(@"Scope|This CollateralSubstitutionConfirmation message is sent by:|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager.|This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released. In the event that multiple pieces of collateral are being delivered in place of the collateral due to be returned by the giver, this message should only be generated once all collateral pieces have been agreed between both parties. Then the taker confirms that the collateral substitution (that is all pieces have been received) and acknowledges return of collateral.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released.")]
[IsoId("_7A0N0WNmEeSIWbZ6by9dnA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Collateral Substitution Confirmation V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralSubstitutionConfirmationV03 : IOuterRecord<CollateralSubstitutionConfirmationV03,CollateralSubstitutionConfirmationV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.012.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CollateralSubstitutionConfirmationV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralSubstitutionConfirmationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralSubstitutionConfirmationV03( System.String reqTransactionIdentification,Obligation3 reqObligation,CollateralConfirmation1 reqSubstitutionConfirmation )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
        SubstitutionConfirmation = reqSubstitutionConfirmation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_7A0N02NmEeSIWbZ6by9dnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_E3xr4GNnEeSIWbZ6by9dnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Obligation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation3 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Obligation3 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation3 Obligation { get; init; } 
    #else
    public Obligation3 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_7A0N3WNmEeSIWbZ6by9dnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agreement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement2? Agreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement2? Agreement { get; init; } 
    #else
    public Agreement2? Agreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status about the collateral substitution.
    /// </summary>
    [IsoId("_7A0N32NmEeSIWbZ6by9dnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Substitution Confirmation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralConfirmation1 SubstitutionConfirmation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CollateralConfirmation1 SubstitutionConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralConfirmation1 SubstitutionConfirmation { get; init; } 
    #else
    public CollateralConfirmation1 SubstitutionConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_7A0N4WNmEeSIWbZ6by9dnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralSubstitutionConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralSubstitutionConfirmationV03Document ToDocument()
    {
        return new CollateralSubstitutionConfirmationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralSubstitutionConfirmationV03"/>.
/// </summary>
[Serializable]
public partial record CollateralSubstitutionConfirmationV03Document : IOuterDocument<CollateralSubstitutionConfirmationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.012.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralSubstitutionConfirmationV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralSubstitutionConfirmationV03 Message { get; init; }
    #else
    public CollateralSubstitutionConfirmationV03 Message { get; init; }
    #endif
}
