﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraPositionMovementConfirmationV09.  ISO2002 ID# _z7mNYSgOEeym1_Zp1BTvEw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.semt.IntraPositionMovementConfirmationV09>;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// This record is an implementation of the semt.015.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IntraPositionMovementConfirmation is sent by an account servicer to an account owner to confirm the movement of securities within its holding from one sub-balance to another, for example, blocking of securities. 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of its participant
/// - an agent (sub-custodian) acting on behalf of  its global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|The IntraPositionMovementConfirmation is sent by an account servicer to an account owner to confirm the movement of securities within its holding from one sub-balance to another, for example, blocking of securities. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of its participant|- an agent (sub-custodian) acting on behalf of  its global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record IntraPositionMovementConfirmationV09 : IOuterRecord<IntraPositionMovementConfirmationV09,IntraPositionMovementConfirmationV09Document>
    ,IIsoXmlSerilizable<IntraPositionMovementConfirmationV09>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.015.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => IntraPositionMovementConfirmationV09Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Additional parameters for the transaction.
    /// </summary>
    [IsoId("_z7mNaSgOEeym1_Zp1BTvEw")]
    [Description(@"Additional parameters for the transaction.")]
    [DataMember(Name="AddtlParams")]
    [XmlElement(ElementName="AddtlParams")]
    public AdditionalParameters33? AdditionalParameters { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_z7mNaygOEeym1_Zp1BTvEw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_z7mNbSgOEeym1_Zp1BTvEw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_KoXgQyqAEeyR9JrVGfaMKw")]
    [Description(@"Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.")]
    [DataMember(Name="BlckChainAdrOrWllt")]
    [XmlElement(ElementName="BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_z7mNbygOEeym1_Zp1BTvEw")]
    [Description(@"Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).")]
    [DataMember(Name="SfkpgPlc")]
    [XmlElement(ElementName="SfkpgPlc")]
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlace { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_z7mNcSgOEeym1_Zp1BTvEw")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_z7mNcygOEeym1_Zp1BTvEw")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes112? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Intra-position movement transaction details.
    /// </summary>
    [IsoId("_z7mNdSgOEeym1_Zp1BTvEw")]
    [Description(@"Intra-position movement transaction details.")]
    [DataMember(Name="IntraPosDtls")]
    [XmlElement(ElementName="IntraPosDtls")]
    [Required]
    public required IntraPositionDetails59 IntraPositionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_z7mNdygOEeym1_Zp1BTvEw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraPositionMovementConfirmationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraPositionMovementConfirmationV09Document ToDocument()
    {
        return new IntraPositionMovementConfirmationV09Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("IntraPosMvmntConf");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (AdditionalParameters is AdditionalParameters33 AdditionalParametersValue)
        {
            writer.WriteStartElement(null, "AddtlParams", xmlNamespace );
            AdditionalParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification127Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount19 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockChainAddressOrWallet is BlockChainAddressWallet3 BlockChainAddressOrWalletValue)
        {
            writer.WriteStartElement(null, "BlckChainAdrOrWllt", xmlNamespace );
            BlockChainAddressOrWalletValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormat29Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes112 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "IntraPosDtls", xmlNamespace );
        IntraPositionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IntraPositionMovementConfirmationV09 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraPositionMovementConfirmationV09"/>.
/// </summary>
[Serializable]
public partial record IntraPositionMovementConfirmationV09Document : IOuterDocument<IntraPositionMovementConfirmationV09>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.015.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraPositionMovementConfirmationV09"/> is required.
    /// </summary>
    [DataMember(Name=IntraPositionMovementConfirmationV09.XmlTag)]
    public required IntraPositionMovementConfirmationV09 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(IntraPositionMovementConfirmationV09.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
