﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportLine6.  ISO2002 ID# _TK73gRrYEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a payment against a commercial invoice.
/// </summary>
public partial record ReportLine6
     : IIsoXmlSerilizable<ReportLine6>
{
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    public Adjustment6? Adjustment { get; init; } 
    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    public required IsoCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Specifies how the net amount to be paid is related to different purchase orders.
    /// </summary>
    public ReportLine7? BreakdownByPurchaseOrder { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Ti7gxxrYEeOVR9VN6fAMUg
    
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
        writer.WriteStartElement(null, "ComrclDocRef", xmlNamespace );
        CommercialDocumentReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Adjustment is Adjustment6 AdjustmentValue)
        {
            writer.WriteStartElement(null, "Adjstmnt", xmlNamespace );
            AdjustmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NetAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(NetAmount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        // Not sure how to serialize BreakdownByPurchaseOrder, multiplicity Unknown
    }
    public static ReportLine6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
