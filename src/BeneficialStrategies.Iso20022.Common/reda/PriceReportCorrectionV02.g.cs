﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportCorrectionV02.  ISO2002 ID# _Zs3dytEvEd-BzquC8wXy7w_-233980086.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// Scope
/// The PriceReportCorrection message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.
/// The message is used to correct at least one of the prices, of a financial instrument, that was quoted in a previously sent PriceReport message.
/// Usage
/// The PriceReportCorrection message is used to correct information in a PriceReport message that was previously sent by the fund accountant. If an entire PriceReport message must be corrected, eg, due to an incorrect trade date, it is recommended that a PriceReportCancellation message is used to cancel the entire PriceReport message and a new PriceReport message is sent.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The PriceReportCorrection message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.|The message is used to correct at least one of the prices, of a financial instrument, that was quoted in a previously sent PriceReport message.|Usage|The PriceReportCorrection message is used to correct information in a PriceReport message that was previously sent by the fund accountant. If an entire PriceReport message must be corrected, eg, due to an incorrect trade date, it is recommended that a PriceReportCancellation message is used to cancel the entire PriceReport message and a new PriceReport message is sent.")]
public partial record PriceReportCorrectionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "reda.003.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Zs3dy9EvEd-BzquC8wXy7w_-1170807267")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Zs3dzNEvEd-BzquC8wXy7w_-1180041935")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    [Required]
    public required SomePreviousReferenceRecord PreviousReference { get; init; }
    
    /// <summary>
    /// Information related to the correction of a price of a financial instrument.
    /// </summary>
    [IsoId("_Zs3dzdEvEd-BzquC8wXy7w_292430358")]
    [Description(@"Information related to the correction of a price of a financial instrument.")]
    [DataMember(Name="PricCrrctnDtls")]
    [XmlElement(ElementName="PricCrrctnDtls")]
    [Required]
    public required SomePriceCorrectionDetailsRecord PriceCorrectionDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportCorrectionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportCorrectionV02Document ToDocument()
    {
        return new PriceReportCorrectionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportCorrectionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PriceReportCorrectionV02Document : IOuterDocument<PriceReportCorrectionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportCorrectionV02"/> is required.
    /// </summary>
    public required PriceReportCorrectionV02 Message { get; init; }
}
