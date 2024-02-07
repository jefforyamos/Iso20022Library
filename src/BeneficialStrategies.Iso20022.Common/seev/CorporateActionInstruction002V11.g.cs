﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstruction002V11.  ISO2002 ID# _F-cEQx9REeuFz_FaCzCLgQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.CorporateActionInstruction002V11>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.033.002.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionInstruction message is sent by an account owner to an account servicer to instruct election on a corporate action event.|
/// This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|The CorporateActionInstruction message is sent by an account owner to an account servicer to instruct election on a corporate action event.||This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionInstruction002V11 : IOuterRecord<CorporateActionInstruction002V11,CorporateActionInstruction002V11Document>
    ,IIsoXmlSerilizable<CorporateActionInstruction002V11>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.033.002.11";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionInstruction002V11Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Indicates that the current instruction is replacing a previous one that was cancelled earlier.
    /// </summary>
    [IsoId("_F-cEVB9REeuFz_FaCzCLgQ")]
    [Description(@"Indicates that the current instruction is replacing a previous one that was cancelled earlier.")]
    [DataMember(Name="ChngInstrInd")]
    [XmlElement(ElementName="ChngInstrInd")]
    public IsoYesNoIndicator? ChangeInstructionIndicator { get; init; }
    
    /// <summary>
    /// Identification of a previously sent cancelled instruction document.
    /// </summary>
    [IsoId("_F-cEVh9REeuFz_FaCzCLgQ")]
    [Description(@"Identification of a previously sent cancelled instruction document.")]
    [DataMember(Name="CancInstrId")]
    [XmlElement(ElementName="CancInstrId")]
    public DocumentIdentification37? CancelledInstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent instruction cancellation request document.
    /// </summary>
    [IsoId("_F-cEWB9REeuFz_FaCzCLgQ")]
    [Description(@"Identification of a previously sent instruction cancellation request document.")]
    [DataMember(Name="InstrCxlReqId")]
    [XmlElement(ElementName="InstrCxlReqId")]
    public DocumentIdentification37? InstructionCancellationRequestIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_F-cEWh9REeuFz_FaCzCLgQ")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification38? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_F-cEXB9REeuFz_FaCzCLgQ")]
    [Description(@"Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReference4? EventsLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_F-cEXh9REeuFz_FaCzCLgQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation161 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_F-cEYB9REeuFz_FaCzCLgQ")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required AccountAndBalance44 AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the beneficial owner of the securities.
    /// </summary>
    [IsoId("_F-cEYh9REeuFz_FaCzCLgQ")]
    [Description(@"Information about the beneficial owner of the securities.")]
    [DataMember(Name="BnfclOwnrDtls")]
    [XmlElement(ElementName="BnfclOwnrDtls")]
    public PartyIdentification244? BeneficialOwnerDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_F-cEZB9REeuFz_FaCzCLgQ")]
    [Description(@"Information about the corporate action instruction.")]
    [DataMember(Name="CorpActnInstr")]
    [XmlElement(ElementName="CorpActnInstr")]
    [Required]
    public required CorporateActionOption188 CorporateActionInstruction { get; init; }
    
    /// <summary>
    /// Provides detailed information on protect and cover protect instructions.
    /// </summary>
    [IsoId("_F-cEZh9REeuFz_FaCzCLgQ")]
    [Description(@"Provides detailed information on protect and cover protect instructions.")]
    [DataMember(Name="PrtctInstr")]
    [XmlElement(ElementName="PrtctInstr")]
    public ProtectInstruction5? ProtectInstruction { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_F-cEaB9REeuFz_FaCzCLgQ")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative34? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_F-cEah9REeuFz_FaCzCLgQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstruction002V11Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstruction002V11Document ToDocument()
    {
        return new CorporateActionInstruction002V11Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CorpActnInstr");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (ChangeInstructionIndicator is IsoYesNoIndicator ChangeInstructionIndicatorValue)
        {
            writer.WriteStartElement(null, "ChngInstrInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ChangeInstructionIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CancelledInstructionIdentification is DocumentIdentification37 CancelledInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "CancInstrId", xmlNamespace );
            CancelledInstructionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionCancellationRequestIdentification is DocumentIdentification37 InstructionCancellationRequestIdentificationValue)
        {
            writer.WriteStartElement(null, "InstrCxlReqId", xmlNamespace );
            InstructionCancellationRequestIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherDocumentIdentification is DocumentIdentification38 OtherDocumentIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrDocId", xmlNamespace );
            OtherDocumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EventsLinkage is CorporateActionEventReference4 EventsLinkageValue)
        {
            writer.WriteStartElement(null, "EvtsLkg", xmlNamespace );
            EventsLinkageValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BeneficialOwnerDetails is PartyIdentification244 BeneficialOwnerDetailsValue)
        {
            writer.WriteStartElement(null, "BnfclOwnrDtls", xmlNamespace );
            BeneficialOwnerDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CorpActnInstr", xmlNamespace );
        CorporateActionInstruction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProtectInstruction is ProtectInstruction5 ProtectInstructionValue)
        {
            writer.WriteStartElement(null, "PrtctInstr", xmlNamespace );
            ProtectInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is CorporateActionNarrative34 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionInstruction002V11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstruction002V11"/>.
/// </summary>
[Serializable]
public partial record CorporateActionInstruction002V11Document : IOuterDocument<CorporateActionInstruction002V11>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.033.002.11";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstruction002V11"/> is required.
    /// </summary>
    [DataMember(Name=CorporateActionInstruction002V11.XmlTag)]
    public required CorporateActionInstruction002V11 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CorporateActionInstruction002V11.XmlTag);
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
