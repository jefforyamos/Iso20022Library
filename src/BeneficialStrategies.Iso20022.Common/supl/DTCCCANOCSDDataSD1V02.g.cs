﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOCSDDataSD1V02.  ISO2002 ID# _1MESNTL3EeKU9IrkkToqcw_405434818.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCANOCSDDataSD1V02>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.
/// </summary>
[Serializable]
[Description(@"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.")]
public partial record DTCCCANOCSDDataSD1V02 : IOuterRecord<DTCCCANOCSDDataSD1V02,DTCCCANOCSDDataSD1V02Document>
    ,IIsoXmlSerilizable<DTCCCANOCSDDataSD1V02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCANOCSDDataSD1V02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Number and continuation indicator used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_1MESNjL3EeKU9IrkkToqcw_953243499")]
    [Description(@"Number and continuation indicator used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination? Pagination { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_1MESNzL3EeKU9IrkkToqcw_413108357")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="NtfctnGnlInfXtnsn")]
    [XmlElement(ElementName="NtfctnGnlInfXtnsn")]
    public CorporateActionNotificationSD3? NotificationGeneralInformationExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_1MODMDL3EeKU9IrkkToqcw_939060651")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="CorpActnGnlInfXtnsn")]
    [XmlElement(ElementName="CorpActnGnlInfXtnsn")]
    public CorporateActionGeneralInformationSD9? CorporateActionGeneralInformationExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_1MODMTL3EeKU9IrkkToqcw_279330117")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygSctyXtnsn")]
    [XmlElement(ElementName="UndrlygSctyXtnsn")]
    public FinancialInstrumentAttributesSD6? UnderlyingSecurityExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_1MODMjL3EeKU9IrkkToqcw_-613312639")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtlsXtnsn")]
    [XmlElement(ElementName="CorpActnDtlsXtnsn")]
    public CorporateActionSD3? CorporateActionDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_1MODMzL3EeKU9IrkkToqcw_-972271225")]
    [Description(@"Information to be extended as supplementary data to corporate action date details.")]
    [DataMember(Name="CorpActnDtDtlsXtnsn")]
    [XmlElement(ElementName="CorpActnDtDtlsXtnsn")]
    public CorporateActionDateSD3? CorporateActionDateDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_1MODNDL3EeKU9IrkkToqcw_1791320847")]
    [Description(@"Information to be extended as corporate action price supplementary data.")]
    [DataMember(Name="CorpActnPricDtlsXtnsn")]
    [XmlElement(ElementName="CorpActnPricDtlsXtnsn")]
    public CorporateActionPriceSD3? CorporateActionPriceDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_1MODNTL3EeKU9IrkkToqcw_-573969811")]
    [Description(@"Information to be extended as supplementary data to corporate action period.")]
    [DataMember(Name="CorpActnPrdDtlsXtnsn")]
    [XmlElement(ElementName="CorpActnPrdDtlsXtnsn")]
    public CorporateActionPeriodSD1? CorporateActionPeriodDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_1MXNIDL3EeKU9IrkkToqcw_-2139645596")]
    [Description(@"Information to be extended as supplementary data to corporate action rate and amount.")]
    [DataMember(Name="CorpActnRateAndAmtDtlsXtnsn")]
    [XmlElement(ElementName="CorpActnRateAndAmtDtlsXtnsn")]
    public CorporateActionRateSD1? CorporateActionRateAndAmountDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_1MXNITL3EeKU9IrkkToqcw_-188585172")]
    [Description(@"Information to be extended as supplementary data to corporate action securities quantity.")]
    [DataMember(Name="CorpActnSctiesQtyXtnsn")]
    [XmlElement(ElementName="CorpActnSctiesQtyXtnsn")]
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantityExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_1MXNIjL3EeKU9IrkkToqcw_-2006832664")]
    [Description(@"Information to be extended as supplementary data to option details.")]
    [DataMember(Name="OptnDtlsXtnsn")]
    [XmlElement(ElementName="OptnDtlsXtnsn")]
    public CorporateActionOptionSD4? OptionDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_1MXNIzL3EeKU9IrkkToqcw_-1328983965")]
    [Description(@"Information to be extended as supplementary data to securities movement details.")]
    [DataMember(Name="SctiesMvmntDtlsXtnsn")]
    [XmlElement(ElementName="SctiesMvmntDtlsXtnsn")]
    public SecuritiesOptionSD3? SecuritiesMovementDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_1MXNJDL3EeKU9IrkkToqcw_774044256")]
    [Description(@"Information to be extended as supplementary data to securities movement security details.")]
    [DataMember(Name="SctiesMvmntSctyDtlsXtnsn")]
    [XmlElement(ElementName="SctiesMvmntSctyDtlsXtnsn")]
    public FinancialInstrumentAttributesSD1? SecuritiesMovementSecurityDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_1MXNJTL3EeKU9IrkkToqcw_1306046274")]
    [Description(@"Information to be extended as supplementary data to securities movement rate details.")]
    [DataMember(Name="SctiesMvmntRateDtlsXtnsn")]
    [XmlElement(ElementName="SctiesMvmntRateDtlsXtnsn")]
    public CorporateActionRateSD3? SecuritiesMovementRateDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as securities movement cash in lieu supplementary data.
    /// </summary>
    [IsoId("_1MXNJjL3EeKU9IrkkToqcw_-1345714107")]
    [Description(@"Information to be extended as securities movement cash in lieu supplementary data.")]
    [DataMember(Name="SctiesMvmntCshInLieuDtlsXtnsn")]
    [XmlElement(ElementName="SctiesMvmntCshInLieuDtlsXtnsn")]
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_1Mg-IDL3EeKU9IrkkToqcw_-1092733027")]
    [Description(@"Information to be extended as supplementary data to securities movement fraction disposition.")]
    [DataMember(Name="SctiesMvmntFrctnDspstnXtnsn")]
    [XmlElement(ElementName="SctiesMvmntFrctnDspstnXtnsn")]
    public FractionDispositionTypeSD1? SecuritiesMovementFractionDispositionExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_1Mg-ITL3EeKU9IrkkToqcw_-2105914908")]
    [Description(@"Information to be extended as supplementary data to cash movement details.")]
    [DataMember(Name="CshMvmntDtlsXtnsn")]
    [XmlElement(ElementName="CshMvmntDtlsXtnsn")]
    public CashOptionSD4? CashMovementDetailsExtension { get; init; }
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_1Mg-IjL3EeKU9IrkkToqcw_1370775805")]
    [Description(@"Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.")]
    [DataMember(Name="NewAgtXtnsn")]
    [XmlElement(ElementName="NewAgtXtnsn")]
    public PartyIdentificationSD1? NewAgentExtension { get; init; }
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like "issuer agent", "reselling agent", etc). Used when required "ISO agent type" exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_1Mg-IzL3EeKU9IrkkToqcw_-1692264305")]
    [Description(@"Provides additional information to agent details (to message agent like ""issuer agent"", ""reselling agent"", etc). Used when required ""ISO agent type"" exists and only additional details need to be extended.")]
    [DataMember(Name="AgtXtnsn")]
    [XmlElement(ElementName="AgtXtnsn")]
    public PartyIdentificationSD2? AgentExtension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOCSDDataSD1V02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOCSDDataSD1V02Document ToDocument()
    {
        return new DTCCCANOCSDDataSD1V02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCANOCSDDataSD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Pagination is Pagination PaginationValue)
        {
            writer.WriteStartElement(null, "Pgntn", xmlNamespace );
            PaginationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NotificationGeneralInformationExtension is CorporateActionNotificationSD3 NotificationGeneralInformationExtensionValue)
        {
            writer.WriteStartElement(null, "NtfctnGnlInfXtnsn", xmlNamespace );
            NotificationGeneralInformationExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionGeneralInformationExtension is CorporateActionGeneralInformationSD9 CorporateActionGeneralInformationExtensionValue)
        {
            writer.WriteStartElement(null, "CorpActnGnlInfXtnsn", xmlNamespace );
            CorporateActionGeneralInformationExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingSecurityExtension is FinancialInstrumentAttributesSD6 UnderlyingSecurityExtensionValue)
        {
            writer.WriteStartElement(null, "UndrlygSctyXtnsn", xmlNamespace );
            UnderlyingSecurityExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionDetailsExtension is CorporateActionSD3 CorporateActionDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "CorpActnDtlsXtnsn", xmlNamespace );
            CorporateActionDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionDateDetailsExtension is CorporateActionDateSD3 CorporateActionDateDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "CorpActnDtDtlsXtnsn", xmlNamespace );
            CorporateActionDateDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionPriceDetailsExtension is CorporateActionPriceSD3 CorporateActionPriceDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "CorpActnPricDtlsXtnsn", xmlNamespace );
            CorporateActionPriceDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionPeriodDetailsExtension is CorporateActionPeriodSD1 CorporateActionPeriodDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "CorpActnPrdDtlsXtnsn", xmlNamespace );
            CorporateActionPeriodDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionRateAndAmountDetailsExtension is CorporateActionRateSD1 CorporateActionRateAndAmountDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "CorpActnRateAndAmtDtlsXtnsn", xmlNamespace );
            CorporateActionRateAndAmountDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionSecuritiesQuantityExtension is CorporateActionQuantitySD1 CorporateActionSecuritiesQuantityExtensionValue)
        {
            writer.WriteStartElement(null, "CorpActnSctiesQtyXtnsn", xmlNamespace );
            CorporateActionSecuritiesQuantityExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionDetailsExtension is CorporateActionOptionSD4 OptionDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "OptnDtlsXtnsn", xmlNamespace );
            OptionDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementDetailsExtension is SecuritiesOptionSD3 SecuritiesMovementDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntDtlsXtnsn", xmlNamespace );
            SecuritiesMovementDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementSecurityDetailsExtension is FinancialInstrumentAttributesSD1 SecuritiesMovementSecurityDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntSctyDtlsXtnsn", xmlNamespace );
            SecuritiesMovementSecurityDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementRateDetailsExtension is CorporateActionRateSD3 SecuritiesMovementRateDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntRateDtlsXtnsn", xmlNamespace );
            SecuritiesMovementRateDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementCashInLieuDetailsExtension is CorporateActionPriceSD1 SecuritiesMovementCashInLieuDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntCshInLieuDtlsXtnsn", xmlNamespace );
            SecuritiesMovementCashInLieuDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementFractionDispositionExtension is FractionDispositionTypeSD1 SecuritiesMovementFractionDispositionExtensionValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntFrctnDspstnXtnsn", xmlNamespace );
            SecuritiesMovementFractionDispositionExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashMovementDetailsExtension is CashOptionSD4 CashMovementDetailsExtensionValue)
        {
            writer.WriteStartElement(null, "CshMvmntDtlsXtnsn", xmlNamespace );
            CashMovementDetailsExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewAgentExtension is PartyIdentificationSD1 NewAgentExtensionValue)
        {
            writer.WriteStartElement(null, "NewAgtXtnsn", xmlNamespace );
            NewAgentExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AgentExtension is PartyIdentificationSD2 AgentExtensionValue)
        {
            writer.WriteStartElement(null, "AgtXtnsn", xmlNamespace );
            AgentExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCANOCSDDataSD1V02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOCSDDataSD1V02"/>.
/// </summary>
[Serializable]
public partial record DTCCCANOCSDDataSD1V02Document : IOuterDocument<DTCCCANOCSDDataSD1V02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOCSDDataSD1V02"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCANOCSDDataSD1V02.XmlTag)]
    public required DTCCCANOCSDDataSD1V02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCANOCSDDataSD1V02.XmlTag);
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
