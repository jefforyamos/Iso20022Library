﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOMarketDataSD1V06.  ISO2002 ID# _eaasH12lEeOb__BffbPEig.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCANOMarketDataSD1V06>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.002.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOMarketDataSD1 message extends ISO corporate action notification (CANO) market data message (Market Data type) with data elements that are not covered by the standard message, and additionally, with DTC values where issuer/offeror/market corresponding values are mapped to CANO. For example issuer/offeror/market declared cash rate will be mapped to the CANO and DTC announced cash rate will be extended in this message.
/// </summary>
[Serializable]
[Description(@"The DTCCCANOMarketDataSD1 message extends ISO corporate action notification (CANO) market data message (Market Data type) with data elements that are not covered by the standard message, and additionally, with DTC values where issuer/offeror/market corresponding values are mapped to CANO. For example issuer/offeror/market declared cash rate will be mapped to the CANO and DTC announced cash rate will be extended in this message.")]
public partial record DTCCCANOMarketDataSD1V06 : IOuterRecord<DTCCCANOMarketDataSD1V06,DTCCCANOMarketDataSD1V06Document>
    ,IIsoXmlSerilizable<DTCCCANOMarketDataSD1V06>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.002.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOMktDataSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCANOMarketDataSD1V06Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_eaasIV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    public CorporateActionNotificationSD3? NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_eaasI12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD13? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_eaasJV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD8? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_eaasJ12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD11? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_eaasKV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to corporate action date details.")]
    [DataMember(Name="CorpActnDtDtls")]
    [XmlElement(ElementName="CorpActnDtDtls")]
    public CorporateActionDateSD5? CorporateActionDateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_eaasK12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as corporate action price supplementary data.")]
    [DataMember(Name="CorpActnPricDtls")]
    [XmlElement(ElementName="CorpActnPricDtls")]
    public CorporateActionPriceSD3? CorporateActionPriceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_eaasLV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to corporate action period.")]
    [DataMember(Name="CorpActnPrdDtls")]
    [XmlElement(ElementName="CorpActnPrdDtls")]
    public CorporateActionPeriodSD2? CorporateActionPeriodDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_eaasL12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to corporate action securities quantity.")]
    [DataMember(Name="CorpActnSctiesQty")]
    [XmlElement(ElementName="CorpActnSctiesQty")]
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_eaasMV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to corporate action rate and amount.")]
    [DataMember(Name="CorpActnRateAndAmtDtls")]
    [XmlElement(ElementName="CorpActnRateAndAmtDtls")]
    public CorporateActionRateSD5? CorporateActionRateAndAmountDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_eaasM12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to option details.")]
    [DataMember(Name="OptnDtls")]
    [XmlElement(ElementName="OptnDtls")]
    public CorporateActionOptionSD9? OptionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_eaasNV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to securities movement details.")]
    [DataMember(Name="SctiesMvmntDtls")]
    [XmlElement(ElementName="SctiesMvmntDtls")]
    public SecuritiesOptionSD6? SecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_eaasN12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to securities movement security details.")]
    [DataMember(Name="SctiesMvmntSctyDtls")]
    [XmlElement(ElementName="SctiesMvmntSctyDtls")]
    public FinancialInstrumentAttributesSD3? SecuritiesMovementSecurityDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_eaasOV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to securities movement rate details.")]
    [DataMember(Name="SctiesMvmntRateDtls")]
    [XmlElement(ElementName="SctiesMvmntRateDtls")]
    public CorporateActionRateSD7? SecuritiesMovementRateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement cash in lieu.
    /// </summary>
    [IsoId("_eaasO12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to securities movement cash in lieu.")]
    [DataMember(Name="SctiesMvmntCshInLieuDtls")]
    [XmlElement(ElementName="SctiesMvmntCshInLieuDtls")]
    public CorporateActionPriceSD2? SecuritiesMovementCashInLieuDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_eaasPV2lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to securities movement fraction disposition.")]
    [DataMember(Name="SctiesMvmntFrctnDspstn")]
    [XmlElement(ElementName="SctiesMvmntFrctnDspstn")]
    public FractionDispositionTypeSD2? SecuritiesMovementFractionDisposition { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_eaasP12lEeOb__BffbPEig")]
    [Description(@"Information to be extended as supplementary data to cash movement details.")]
    [DataMember(Name="CshMvmntDtls")]
    [XmlElement(ElementName="CshMvmntDtls")]
    public CashOptionSD7? CashMovementDetails { get; init; }
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like "issuer agent", "reselling agent", etc). Used when required "ISO agent type" exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_eaasQV2lEeOb__BffbPEig")]
    [Description(@"Provides additional information to agent details (to message agent like ""issuer agent"", ""reselling agent"", etc). Used when required ""ISO agent type"" exists and only additional details need to be extended.")]
    [DataMember(Name="Agt")]
    [XmlElement(ElementName="Agt")]
    public PartyIdentificationSD2? Agent { get; init; }
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_eaasQ12lEeOb__BffbPEig")]
    [Description(@"Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.")]
    [DataMember(Name="NewAgt")]
    [XmlElement(ElementName="NewAgt")]
    public PartyIdentificationSD1? NewAgent { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOMarketDataSD1V06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOMarketDataSD1V06Document ToDocument()
    {
        return new DTCCCANOMarketDataSD1V06Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCANOMktDataSD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (NotificationGeneralInformation is CorporateActionNotificationSD3 NotificationGeneralInformationValue)
        {
            writer.WriteStartElement(null, "NtfctnGnlInf", xmlNamespace );
            NotificationGeneralInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionGeneralInformation is CorporateActionGeneralInformationSD13 CorporateActionGeneralInformationValue)
        {
            writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
            CorporateActionGeneralInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingSecurity is FinancialInstrumentAttributesSD8 UnderlyingSecurityValue)
        {
            writer.WriteStartElement(null, "UndrlygScty", xmlNamespace );
            UnderlyingSecurityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionDetails is CorporateActionSD11 CorporateActionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtls", xmlNamespace );
            CorporateActionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionDateDetails is CorporateActionDateSD5 CorporateActionDateDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtDtls", xmlNamespace );
            CorporateActionDateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionPriceDetails is CorporateActionPriceSD3 CorporateActionPriceDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnPricDtls", xmlNamespace );
            CorporateActionPriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionPeriodDetails is CorporateActionPeriodSD2 CorporateActionPeriodDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnPrdDtls", xmlNamespace );
            CorporateActionPeriodDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionSecuritiesQuantity is CorporateActionQuantitySD1 CorporateActionSecuritiesQuantityValue)
        {
            writer.WriteStartElement(null, "CorpActnSctiesQty", xmlNamespace );
            CorporateActionSecuritiesQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionRateAndAmountDetails is CorporateActionRateSD5 CorporateActionRateAndAmountDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnRateAndAmtDtls", xmlNamespace );
            CorporateActionRateAndAmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionDetails is CorporateActionOptionSD9 OptionDetailsValue)
        {
            writer.WriteStartElement(null, "OptnDtls", xmlNamespace );
            OptionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementDetails is SecuritiesOptionSD6 SecuritiesMovementDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntDtls", xmlNamespace );
            SecuritiesMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementSecurityDetails is FinancialInstrumentAttributesSD3 SecuritiesMovementSecurityDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntSctyDtls", xmlNamespace );
            SecuritiesMovementSecurityDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementRateDetails is CorporateActionRateSD7 SecuritiesMovementRateDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntRateDtls", xmlNamespace );
            SecuritiesMovementRateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementCashInLieuDetails is CorporateActionPriceSD2 SecuritiesMovementCashInLieuDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntCshInLieuDtls", xmlNamespace );
            SecuritiesMovementCashInLieuDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementFractionDisposition is FractionDispositionTypeSD2 SecuritiesMovementFractionDispositionValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntFrctnDspstn", xmlNamespace );
            SecuritiesMovementFractionDispositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashMovementDetails is CashOptionSD7 CashMovementDetailsValue)
        {
            writer.WriteStartElement(null, "CshMvmntDtls", xmlNamespace );
            CashMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Agent is PartyIdentificationSD2 AgentValue)
        {
            writer.WriteStartElement(null, "Agt", xmlNamespace );
            AgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewAgent is PartyIdentificationSD1 NewAgentValue)
        {
            writer.WriteStartElement(null, "NewAgt", xmlNamespace );
            NewAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCANOMarketDataSD1V06 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOMarketDataSD1V06"/>.
/// </summary>
[Serializable]
public partial record DTCCCANOMarketDataSD1V06Document : IOuterDocument<DTCCCANOMarketDataSD1V06>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.002.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOMarketDataSD1V06"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCANOMarketDataSD1V06.XmlTag)]
    public required DTCCCANOMarketDataSD1V06 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCANOMarketDataSD1V06.XmlTag);
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
