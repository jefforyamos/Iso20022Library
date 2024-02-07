﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NumberOfTransactionsPerStatus5.  ISO2002 ID# _-qEw2ZRuEeazAtAtDSg0Nw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
public partial record NumberOfTransactionsPerStatus5
     : IIsoXmlSerilizable<NumberOfTransactionsPerStatus5>
{
    #nullable enable
    
    /// <summary>
    /// Number of individual transactions contained in the message, detailed per status.
    /// </summary>
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; } 
    /// <summary>
    /// Common transaction status for all individual transactions reported.
    /// </summary>
    public required ExternalPaymentTransactionStatus1Code DetailedStatus { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    public IsoDecimalNumber? DetailedControlSum { get; init; } 
    
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
        writer.WriteStartElement(null, "DtldNbOfTxs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(DetailedNumberOfTransactions)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DtldSts", xmlNamespace );
        writer.WriteValue(DetailedStatus.ToString()); // Enum value
        writer.WriteEndElement();
        if (DetailedControlSum is IsoDecimalNumber DetailedControlSumValue)
        {
            writer.WriteStartElement(null, "DtldCtrlSum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(DetailedControlSumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
    }
    public static NumberOfTransactionsPerStatus5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
