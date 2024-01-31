﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralSubstitutionConfirmationV03.  ISO2002 ID# _7A0N0WNmEeSIWbZ6by9dnA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.colr;


/// <summary>
/// Scope
/// This CollateralSubstitutionConfirmation message is sent by:
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager.
/// This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released. In the event that multiple pieces of collateral are being delivered in place of the collateral due to be returned by the giver, this message should only be generated once all collateral pieces have been agreed between both parties. Then the taker confirms that the collateral substitution (that is all pieces have been received) and acknowledges return of collateral.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This CollateralSubstitutionConfirmation message is sent by:|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager.|This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released. In the event that multiple pieces of collateral are being delivered in place of the collateral due to be returned by the giver, this message should only be generated once all collateral pieces have been agreed between both parties. Then the taker confirms that the collateral substitution (that is all pieces have been received) and acknowledges return of collateral.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released.")]
public partial record CollateralSubstitutionConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnConf";
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_7A0N02NmEeSIWbZ6by9dnA")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required IsoMax35Text TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_E3xr4GNnEeSIWbZ6by9dnA")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation3 Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_7A0N3WNmEeSIWbZ6by9dnA")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public Agreement2? Agreement { get; init; }
    
    /// <summary>
    /// Provides the status about the collateral substitution.
    /// </summary>
    [IsoId("_7A0N32NmEeSIWbZ6by9dnA")]
    [Description(@"Provides the status about the collateral substitution.")]
    [DataMember(Name="SbstitnConf")]
    [XmlElement(ElementName="SbstitnConf")]
    [Required]
    public required CollateralConfirmation1 SubstitutionConfirmation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_7A0N4WNmEeSIWbZ6by9dnA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
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
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
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
    public required CollateralSubstitutionConfirmationV03 Message { get; init; }
}
