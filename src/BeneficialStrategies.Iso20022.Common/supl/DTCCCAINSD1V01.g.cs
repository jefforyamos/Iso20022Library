﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAINSD1V01.  ISO2002 ID# _1Mz5EDL3EeKU9IrkkToqcw_1438480682.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAINSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAINSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// DTC (The Depository Trust Corporation) Optional Dividend service election.
    /// </summary>
    [IsoId("_1Mz5ETL3EeKU9IrkkToqcw_-868730910")]
    [Description(@"DTC (The Depository Trust Corporation) Optional Dividend service election.")]
    [DataMember(Name="OptnlDvdd")]
    [XmlElement(ElementName="OptnlDvdd")]
    public SomeOptionalDividendRecord? OptionalDividend { get; init; }
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Tax Exempt service election.
    /// </summary>
    [IsoId("_1Mz5EjL3EeKU9IrkkToqcw_1039926111")]
    [Description(@"DTC (The Depository Trust Corporation) Tax Exempt service election.")]
    [DataMember(Name="TaxXmpt")]
    [XmlElement(ElementName="TaxXmpt")]
    public SomeTaxExemptRecord? TaxExempt { get; init; }
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Foreign Currency Payment service wire payment instruction.
    /// </summary>
    [IsoId("_1Mz5EzL3EeKU9IrkkToqcw_-2087888194")]
    [Description(@"DTC (The Depository Trust Corporation) Foreign Currency Payment service wire payment instruction.")]
    [DataMember(Name="WireInstr")]
    [XmlElement(ElementName="WireInstr")]
    public SomeWireInstructionRecord? WireInstruction { get; init; }
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Tax Relief service election.
    /// </summary>
    [IsoId("_1Mz5FDL3EeKU9IrkkToqcw_-1885590787")]
    [Description(@"DTC (The Depository Trust Corporation) Tax Relief service election.")]
    [DataMember(Name="DTCTaxRlf")]
    [XmlElement(ElementName="DTCTaxRlf")]
    public SomeDTCTaxReliefRecord? DTCTaxRelief { get; init; }
    
    /// <summary>
    /// U.S. Tax Withholding elections.
    /// </summary>
    [IsoId("_1Mz5FTL3EeKU9IrkkToqcw_-63987189")]
    [Description(@"U.S. Tax Withholding elections.")]
    [DataMember(Name="USTaxWhldg")]
    [XmlElement(ElementName="USTaxWhldg")]
    public SomeUSTaxWithholdingRecord? USTaxWithholding { get; init; }
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Cash In Lieu service election.
    /// </summary>
    [IsoId("_1Mz5FjL3EeKU9IrkkToqcw_1321235420")]
    [Description(@"DTC (The Depository Trust Corporation) Cash In Lieu service election.")]
    [DataMember(Name="CshInLieu")]
    [XmlElement(ElementName="CshInLieu")]
    public SomeCashInLieuRecord? CashInLieu { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAINSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAINSD1V01Document ToDocument()
    {
        return new DTCCCAINSD1V01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAINSD1V01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAINSD1V01Document : IOuterDocument<DTCCCAINSD1V01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAINSD1V01"/> is required.
    /// </summary>
    public required DTCCCAINSD1V01 Message { get; init; }
}
