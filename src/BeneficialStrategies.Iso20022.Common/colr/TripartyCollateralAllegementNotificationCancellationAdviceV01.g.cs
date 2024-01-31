﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TripartyCollateralAllegementNotificationCancellationAdviceV01.  ISO2002 ID# _rvMtQSs7EeySlt9bF77XfA.
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
/// Scope:
/// Triparty agent sends a TripartyCollateralAllegementNotificationCancellationAdvice to the collateral giver or the collateral taker to inform of the cancellation of an allegement notification message previously sent by the triparty agent. 
/// The collateral giver and the collateral taker are participants of the triparty agents. In the frame of ECMS the collateral taker will be a central bank.
/// The previously sent message is a TripartyCollateralAllegementNotification
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope:|Triparty agent sends a TripartyCollateralAllegementNotificationCancellationAdvice to the collateral giver or the collateral taker to inform of the cancellation of an allegement notification message previously sent by the triparty agent. ||The collateral giver and the collateral taker are participants of the triparty agents. In the frame of ECMS the collateral taker will be a central bank.||The previously sent message is a TripartyCollateralAllegementNotification")]
public partial record TripartyCollateralAllegementNotificationCancellationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollAllgmtNtfctnCxlAdvc";
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_rvMtQys7EeySlt9bF77XfA")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.||")]
    [DataMember(Name="TxInstrId")]
    [XmlElement(ElementName="TxInstrId")]
    [Required]
    public required TransactionIdentifications44 TransactionInstructionIdentification { get; init; }
    
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_rvMtRSs7EeySlt9bF77XfA")]
    [Description(@"Specifies the type of collateral instruction.")]
    [DataMember(Name="CollTxTp")]
    [XmlElement(ElementName="CollTxTp")]
    [Required]
    public required ICollateralTransactionType1Choice CollateralTransactionType { get; init; }
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_rvMtRys7EeySlt9bF77XfA")]
    [Description(@"Specifies the underlying business area/type of trade causing the exposure.")]
    [DataMember(Name="XpsrTp")]
    [XmlElement(ElementName="XpsrTp")]
    [Required]
    public required IExposureType23Choice ExposureType { get; init; }
    
    /// <summary>
    /// Specifies whether the alleging side is the collateral taker or giver.
    /// </summary>
    [IsoId("_rvMtSSs7EeySlt9bF77XfA")]
    [Description(@"Specifies whether the alleging side is the collateral taker or giver.|")]
    [DataMember(Name="CollSd")]
    [XmlElement(ElementName="CollSd")]
    [Required]
    public required CollateralRole1Code CollateralSide { get; init; }
    
    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_rvMtSys7EeySlt9bF77XfA")]
    [Description(@"Number identifying the collateral eligibility set profile of the counterparty.")]
    [DataMember(Name="ElgbltySetPrfl")]
    [XmlElement(ElementName="ElgbltySetPrfl")]
    public GenericIdentification1? EligibilitySetProfile { get; init; }
    
    /// <summary>
    /// Identifies the chain of collateral parties. Party A and B will be the opposite  from that provided in the unmatched instruction.
    /// </summary>
    [IsoId("_rvMtTSs7EeySlt9bF77XfA")]
    [Description(@"Identifies the chain of collateral parties. Party A and B will be the opposite  from that provided in the unmatched instruction.")]
    [DataMember(Name="CollPties")]
    [XmlElement(ElementName="CollPties")]
    [Required]
    public required CollateralParties8 CollateralParties { get; init; }
    
    /// <summary>
    /// Amount of the principal.
    /// </summary>
    [IsoId("_rvMtTys7EeySlt9bF77XfA")]
    [Description(@"Amount of the principal.")]
    [DataMember(Name="TxAmt")]
    [XmlElement(ElementName="TxAmt")]
    public AmountAndDirection49? TransactionAmount { get; init; }
    
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    [IsoId("_rvMtUSs7EeySlt9bF77XfA")]
    [Description(@"Date/time at which the instructing party requests the instruction to be executed. ")]
    [DataMember(Name="ReqdExctnDt")]
    [XmlElement(ElementName="ReqdExctnDt")]
    public IDateAndDateTime2Choice? RequestedExecutionDate { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rvMtUys7EeySlt9bF77XfA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TripartyCollateralAllegementNotificationCancellationAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TripartyCollateralAllegementNotificationCancellationAdviceV01Document ToDocument()
    {
        return new TripartyCollateralAllegementNotificationCancellationAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TripartyCollateralAllegementNotificationCancellationAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TripartyCollateralAllegementNotificationCancellationAdviceV01Document : IOuterDocument<TripartyCollateralAllegementNotificationCancellationAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.024.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TripartyCollateralAllegementNotificationCancellationAdviceV01"/> is required.
    /// </summary>
    public required TripartyCollateralAllegementNotificationCancellationAdviceV01 Message { get; init; }
}
