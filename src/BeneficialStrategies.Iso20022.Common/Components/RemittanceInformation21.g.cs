﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceInformation21.  ISO2002 ID# _n3SnQd4lEeqt1ZcLzWyWFw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system.
/// </summary>
public partial record RemittanceInformation21
     : IIsoXmlSerilizable<RemittanceInformation21>
{
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in an unstructured form.
    /// </summary>
    public IsoMax140Text? Unstructured { get; init; } 
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
    /// </summary>
    public StructuredRemittanceInformation17? Structured { get; init; } 
    
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
        if (Unstructured is IsoMax140Text UnstructuredValue)
        {
            writer.WriteStartElement(null, "Ustrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(UnstructuredValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (Structured is StructuredRemittanceInformation17 StructuredValue)
        {
            writer.WriteStartElement(null, "Strd", xmlNamespace );
            StructuredValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RemittanceInformation21 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
