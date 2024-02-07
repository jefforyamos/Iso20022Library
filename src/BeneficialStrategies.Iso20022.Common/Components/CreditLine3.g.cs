﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditLine3.  ISO2002 ID# _oZe7n4Z5Eee8r9VKRbnJSg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the credit line.
/// </summary>
public partial record CreditLine3
     : IIsoXmlSerilizable<CreditLine3>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the credit line is included in the balance.
    /// </summary>
    public required IsoTrueFalseIndicator Included { get; init; } 
    /// <summary>
    /// Type of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    public CreditLineType1Choice_? Type { get; init; } 
    /// <summary>
    /// Amount of money of the credit line.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Date of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    public DateAndDateTime2Choice_? Date { get; init; } 
    
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
        writer.WriteStartElement(null, "Incl", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(Included)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (Type is CreditLineType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Amount is IsoActiveOrHistoricCurrencyAndAmount AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(AmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Date is DateAndDateTime2Choice_ DateValue)
        {
            writer.WriteStartElement(null, "Dt", xmlNamespace );
            DateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CreditLine3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
