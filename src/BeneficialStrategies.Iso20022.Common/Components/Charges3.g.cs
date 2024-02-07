﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charges3.  ISO2002 ID# _tisYa1kyEeGeoaLUQk__nA_-1567404898.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the charges related to the payment transaction.
/// </summary>
public partial record Charges3
     : IIsoXmlSerilizable<Charges3>
{
    #nullable enable
    
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; } 
    /// <summary>
    /// Provides details of the individual charges record.
    /// </summary>
    public ChargesRecord1? Record { get; init; } 
    
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
        if (TotalChargesAndTaxAmount is IsoActiveOrHistoricCurrencyAndAmount TotalChargesAndTaxAmountValue)
        {
            writer.WriteStartElement(null, "TtlChrgsAndTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(TotalChargesAndTaxAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Record is ChargesRecord1 RecordValue)
        {
            writer.WriteStartElement(null, "Rcrd", xmlNamespace );
            RecordValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Charges3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
