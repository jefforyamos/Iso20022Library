﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraPositionMovementConfirmation002V09.  ISO2002 ID# _caYWgzi8Eeydid5dcNPKvg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// Scope
/// The IntraPositionMovementConfirmation is sent by an account servicer to an account owner to confirm the movement of securities within its holding from one sub-balance to another, for example, blocking of securities. 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of its participant
/// - an agent (sub-custodian) acting on behalf of  its global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The IntraPositionMovementConfirmation is sent by an account servicer to an account owner to confirm the movement of securities within its holding from one sub-balance to another, for example, blocking of securities. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of its participant|- an agent (sub-custodian) acting on behalf of  its global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record IntraPositionMovementConfirmation002V09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntConf";
    
    #nullable enable
    /// <summary>
    /// Additional parameters for the transaction.
    /// </summary>
    [IsoId("_caY9mji8Eeydid5dcNPKvg")]
    [Description(@"Additional parameters for the transaction.")]
    [DataMember(Name="AddtlParams")]
    [XmlElement(ElementName="AddtlParams")]
    public AdditionalParameters34? AdditionalParameters { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_caY9nDi8Eeydid5dcNPKvg")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public IPartyIdentification136Choice? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_caY9nji8Eeydid5dcNPKvg")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    public SecuritiesAccount30? SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_caY9oDi8Eeydid5dcNPKvg")]
    [Description(@"Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.")]
    [DataMember(Name="BlckChainAdrOrWllt")]
    [XmlElement(ElementName="BlckChainAdrOrWllt")]
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; }
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_caY9oji8Eeydid5dcNPKvg")]
    [Description(@"Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).")]
    [DataMember(Name="SfkpgPlc")]
    [XmlElement(ElementName="SfkpgPlc")]
    public ISafekeepingPlaceFormat39Choice? SafekeepingPlace { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_caY9pDi8Eeydid5dcNPKvg")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_caY9pji8Eeydid5dcNPKvg")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes119? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Intra-position movement transaction details.
    /// </summary>
    [IsoId("_caY9qDi8Eeydid5dcNPKvg")]
    [Description(@"Intra-position movement transaction details.")]
    [DataMember(Name="IntraPosDtls")]
    [XmlElement(ElementName="IntraPosDtls")]
    [Required]
    public required IntraPositionDetails61 IntraPositionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_caY9qji8Eeydid5dcNPKvg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraPositionMovementConfirmation002V09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraPositionMovementConfirmation002V09Document ToDocument()
    {
        return new IntraPositionMovementConfirmation002V09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraPositionMovementConfirmation002V09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraPositionMovementConfirmation002V09Document : IOuterDocument<IntraPositionMovementConfirmation002V09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.015.002.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraPositionMovementConfirmation002V09"/> is required.
    /// </summary>
    public required IntraPositionMovementConfirmation002V09 Message { get; init; }
}
