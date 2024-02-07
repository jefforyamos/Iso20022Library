﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstalmentFinancingInformation1.  ISO2002 ID# _PyxaU9p-Ed-ak6NoX_4Aeg_1394536846.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about result of a single instalment (financed or not) within an invoice.
/// </summary>
public partial record InstalmentFinancingInformation1
     : IIsoXmlSerilizable<InstalmentFinancingInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Progressive number of the single instalment related to an invoice.
    /// </summary>
    public required IsoMax70Text InstalmentSequenceIdentification { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public required IsoActiveCurrencyAndAmount InstalmentTotalAmount { get; init; } 
    /// <summary>
    /// Information about the financing result of one instalment.
    /// </summary>
    public required FinancingResult1 InstalmentFinancingResult { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "InstlmtSeqId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax70Text(InstalmentSequenceIdentification)); // data type Max70Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstlmtTtlAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(InstalmentTotalAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstlmtFincgRslt", xmlNamespace );
        InstalmentFinancingResult.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static InstalmentFinancingInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
