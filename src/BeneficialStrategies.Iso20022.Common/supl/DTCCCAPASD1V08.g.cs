﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPASD1V08.  ISO2002 ID# _x6QSEQB6EeqouY-yI_q3qQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCAPASD1V08>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.009.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[Description(@"The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPASD1V08 : IOuterRecord<DTCCCAPASD1V08,DTCCCAPASD1V08Document>
    ,IIsoXmlSerilizable<DTCCCAPASD1V08>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.009.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCAPASD1V08Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_x6QSEwB6EeqouY-yI_q3qQ")]
    [Description(@"Extension block for the information to be extended as corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD43? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_x6QSGwB6EeqouY-yI_q3qQ")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details.
    /// </summary>
    [IsoId("_x6QSHQB6EeqouY-yI_q3qQ")]
    [Description(@"Information to be extended as supplementary data to corporate action balance details.")]
    [DataMember(Name="CorpActnBalDtls")]
    [XmlElement(ElementName="CorpActnBalDtls")]
    public CorporateActionBalanceSD4? CorporateActionBalanceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_x6QSHwB6EeqouY-yI_q3qQ")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD18? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_x6QSIQB6EeqouY-yI_q3qQ")]
    [Description(@"Extension block for the information to be extended as corporate action movement securities movement details.")]
    [DataMember(Name="CorpActnMvmntSctiesMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntSctiesMvmntDtls")]
    public CorporateActionMovementSecuritiesMovementDetailsSD5? CorporateActionMovementSecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_x6QSKQB6EeqouY-yI_q3qQ")]
    [Description(@"Extension block for the information to be extended as corporate action movement cash movement details.")]
    [DataMember(Name="CorpActnMvmntCshMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntCshMvmntDtls")]
    public CorporateActionMovementCashMovementDetailsSD5? CorporateActionMovementCashMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_x6QSMQB6EeqouY-yI_q3qQ")]
    [Description(@"Information to be extended as supplementary data to corporate action option details.")]
    [DataMember(Name="OptnTxDtls")]
    [XmlElement(ElementName="OptnTxDtls")]
    public OptionTransactionDetailsSD3? OptionTransactionDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPASD1V08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPASD1V08Document ToDocument()
    {
        return new DTCCCAPASD1V08Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCAPASD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CorporateActionGeneralInformation is CorporateActionGeneralInformationSD43 CorporateActionGeneralInformationValue)
        {
            writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
            CorporateActionGeneralInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingSecurity is FinancialInstrumentAttributesSD17 UnderlyingSecurityValue)
        {
            writer.WriteStartElement(null, "UndrlygScty", xmlNamespace );
            UnderlyingSecurityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionBalanceDetails is CorporateActionBalanceSD4 CorporateActionBalanceDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnBalDtls", xmlNamespace );
            CorporateActionBalanceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionDetails is CorporateActionSD18 CorporateActionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtls", xmlNamespace );
            CorporateActionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionMovementSecuritiesMovementDetails is CorporateActionMovementSecuritiesMovementDetailsSD5 CorporateActionMovementSecuritiesMovementDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnMvmntSctiesMvmntDtls", xmlNamespace );
            CorporateActionMovementSecuritiesMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionMovementCashMovementDetails is CorporateActionMovementCashMovementDetailsSD5 CorporateActionMovementCashMovementDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnMvmntCshMvmntDtls", xmlNamespace );
            CorporateActionMovementCashMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionTransactionDetails is OptionTransactionDetailsSD3 OptionTransactionDetailsValue)
        {
            writer.WriteStartElement(null, "OptnTxDtls", xmlNamespace );
            OptionTransactionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCAPASD1V08 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAPASD1V08"/>.
/// </summary>
[Serializable]
public partial record DTCCCAPASD1V08Document : IOuterDocument<DTCCCAPASD1V08>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPASD1V08"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCAPASD1V08.XmlTag)]
    public required DTCCCAPASD1V08 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCAPASD1V08.XmlTag);
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
