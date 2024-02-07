﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PEPOrISAOrPortfolioTransferConfirmationV02.  ISO2002 ID# _kezKy9E5Ed-BzquC8wXy7w_-1426890235.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.PEPOrISAOrPortfolioTransferConfirmationV02>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.013.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a (old) plan manager, sends the PEPOrISAOrPortfolioTransferConfirmation message to the instructing party, eg, a (new) plan manager, to confirm the transfer of one or more PEP or ISA or portfolio products from the client's account at the old plan manager to the client's account at the new plan manager through a nominee account.
/// Usage
/// The PEPOrISAOrPortfolioTransferConfirmation message is used to confirm the transfer of one or more PEP or ISA or portfolio products.
/// The reference of each product transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original product transfer is specified in TransferInstructionReference. The message identification of the PEPOrISAPOrPortfolioTransferInstruction message in which the product transfers were conveyed may also be quoted in RelatedReference.
/// </summary>
[Serializable]
[Description(@"Scope|An executing party, eg, a (old) plan manager, sends the PEPOrISAOrPortfolioTransferConfirmation message to the instructing party, eg, a (new) plan manager, to confirm the transfer of one or more PEP or ISA or portfolio products from the client's account at the old plan manager to the client's account at the new plan manager through a nominee account.|Usage|The PEPOrISAOrPortfolioTransferConfirmation message is used to confirm the transfer of one or more PEP or ISA or portfolio products.|The reference of each product transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original product transfer is specified in TransferInstructionReference. The message identification of the PEPOrISAPOrPortfolioTransferInstruction message in which the product transfers were conveyed may also be quoted in RelatedReference.")]
public partial record PEPOrISAOrPortfolioTransferConfirmationV02 : IOuterRecord<PEPOrISAOrPortfolioTransferConfirmationV02,PEPOrISAOrPortfolioTransferConfirmationV02Document>
    ,IIsoXmlSerilizable<PEPOrISAOrPortfolioTransferConfirmationV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.013.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PEPOrISAOrPrtflTrfConfV02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => PEPOrISAOrPortfolioTransferConfirmationV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_kezKzNE5Ed-BzquC8wXy7w_2045616687")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgRef")]
    [XmlElement(ElementName="MsgRef")]
    [Required]
    public required MessageIdentification1 MessageReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_kezKzdE5Ed-BzquC8wXy7w_-1776508711")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_ke87wNE5Ed-BzquC8wXy7w_-1475441471")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_ke87wdE5Ed-BzquC8wXy7w_-1094027263")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_ke87wtE5Ed-BzquC8wXy7w_-1345302241")]
    [Description(@"Information identifying the primary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="PmryIndvInvstr")]
    [XmlElement(ElementName="PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_ke87w9E5Ed-BzquC8wXy7w_-1057165624")]
    [Description(@"Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="ScndryIndvInvstr")]
    [XmlElement(ElementName="ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_ke87xNE5Ed-BzquC8wXy7w_1311997483")]
    [Description(@"Information identifying the other individual investors, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="OthrIndvInvstr")]
    [XmlElement(ElementName="OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_ke87xdE5Ed-BzquC8wXy7w_1458836732")]
    [Description(@"Information identifying the primary corporate investor, eg, name and address.")]
    [DataMember(Name="PmryCorpInvstr")]
    [XmlElement(ElementName="PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_ke87xtE5Ed-BzquC8wXy7w_1788534354")]
    [Description(@"Information identifying the secondary corporate investor, eg, name and address.")]
    [DataMember(Name="ScndryCorpInvstr")]
    [XmlElement(ElementName="ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_ke87x9E5Ed-BzquC8wXy7w_1758058484")]
    [Description(@"Information identifying the other corporate investors, eg, name and address.")]
    [DataMember(Name="OthrCorpInvstr")]
    [XmlElement(ElementName="OthrCorpInvstr")]
    public Organisation4? OtherCorporateInvestor { get; init; }
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_kfGswNE5Ed-BzquC8wXy7w_1391141115")]
    [Description(@"Identification of an account owned by the investor at the old plan manager (account servicer).")]
    [DataMember(Name="ClntAcct")]
    [XmlElement(ElementName="ClntAcct")]
    [Required]
    public required Account5 ClientAccount { get; init; }
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_kfGswdE5Ed-BzquC8wXy7w_-1657996907")]
    [Description(@"Account held in the name of a party that is not the name of the beneficial owner of the shares.")]
    [DataMember(Name="NmneeAcct")]
    [XmlElement(ElementName="NmneeAcct")]
    public Account6? NomineeAccount { get; init; }
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_kfGswtE5Ed-BzquC8wXy7w_-1518546709")]
    [Description(@"Information related to the institution to which the financial instrument is to be transferred.")]
    [DataMember(Name="NewPlanMgr")]
    [XmlElement(ElementName="NewPlanMgr")]
    [Required]
    public required PartyIdentification2Choice_ NewPlanManager { get; init; }
    
    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    [IsoId("_kfGsw9E5Ed-BzquC8wXy7w_713137154")]
    [Description(@"Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).")]
    [DataMember(Name="CshAcct")]
    [XmlElement(ElementName="CshAcct")]
    public CashAccount11? CashAccount { get; init; }
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_kfGsxNE5Ed-BzquC8wXy7w_-671220762")]
    [Description(@"Provides information related to the asset(s) transferred.")]
    [DataMember(Name="PdctTrf")]
    [XmlElement(ElementName="PdctTrf")]
    [Required]
    public required PEPISATransfer4 ProductTransfer { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kfGsxdE5Ed-BzquC8wXy7w_-686452185")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PEPOrISAOrPortfolioTransferConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PEPOrISAOrPortfolioTransferConfirmationV02Document ToDocument()
    {
        return new PEPOrISAOrPortfolioTransferConfirmationV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("PEPOrISAOrPrtflTrfConfV02");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgRef", xmlNamespace );
        MessageReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PoolReference is AdditionalReference3 PoolReferenceValue)
        {
            writer.WriteStartElement(null, "PoolRef", xmlNamespace );
            PoolReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousReference is AdditionalReference3 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedReference is AdditionalReference3 RelatedReferenceValue)
        {
            writer.WriteStartElement(null, "RltdRef", xmlNamespace );
            RelatedReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrimaryIndividualInvestor is IndividualPerson8 PrimaryIndividualInvestorValue)
        {
            writer.WriteStartElement(null, "PmryIndvInvstr", xmlNamespace );
            PrimaryIndividualInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondaryIndividualInvestor is IndividualPerson8 SecondaryIndividualInvestorValue)
        {
            writer.WriteStartElement(null, "ScndryIndvInvstr", xmlNamespace );
            SecondaryIndividualInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherIndividualInvestor is IndividualPerson8 OtherIndividualInvestorValue)
        {
            writer.WriteStartElement(null, "OthrIndvInvstr", xmlNamespace );
            OtherIndividualInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrimaryCorporateInvestor is Organisation4 PrimaryCorporateInvestorValue)
        {
            writer.WriteStartElement(null, "PmryCorpInvstr", xmlNamespace );
            PrimaryCorporateInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondaryCorporateInvestor is Organisation4 SecondaryCorporateInvestorValue)
        {
            writer.WriteStartElement(null, "ScndryCorpInvstr", xmlNamespace );
            SecondaryCorporateInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherCorporateInvestor is Organisation4 OtherCorporateInvestorValue)
        {
            writer.WriteStartElement(null, "OthrCorpInvstr", xmlNamespace );
            OtherCorporateInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ClntAcct", xmlNamespace );
        ClientAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NomineeAccount is Account6 NomineeAccountValue)
        {
            writer.WriteStartElement(null, "NmneeAcct", xmlNamespace );
            NomineeAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NewPlanMgr", xmlNamespace );
        NewPlanManager.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CashAccount is CashAccount11 CashAccountValue)
        {
            writer.WriteStartElement(null, "CshAcct", xmlNamespace );
            CashAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PdctTrf", xmlNamespace );
        ProductTransfer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PEPOrISAOrPortfolioTransferConfirmationV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PEPOrISAOrPortfolioTransferConfirmationV02"/>.
/// </summary>
[Serializable]
public partial record PEPOrISAOrPortfolioTransferConfirmationV02Document : IOuterDocument<PEPOrISAOrPortfolioTransferConfirmationV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.013.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PEPOrISAOrPortfolioTransferConfirmationV02"/> is required.
    /// </summary>
    [DataMember(Name=PEPOrISAOrPortfolioTransferConfirmationV02.XmlTag)]
    public required PEPOrISAOrPortfolioTransferConfirmationV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(PEPOrISAOrPortfolioTransferConfirmationV02.XmlTag);
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
