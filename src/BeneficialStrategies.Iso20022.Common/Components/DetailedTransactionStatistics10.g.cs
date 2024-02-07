﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics10.  ISO2002 ID# _j31tca4cEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about number of transactions accepted and rejected and the reasons of the rejections.
/// </summary>
public partial record DetailedTransactionStatistics10
     : IIsoXmlSerilizable<DetailedTransactionStatistics10>
{
    #nullable enable
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total number of transactions accepted.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfTransactionsAccepted { get; init; } 
    /// <summary>
    /// Total number of transactions rejected.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfTransactionsRejected { get; init; } 
    /// <summary>
    /// Number of transactions rejected per error code.
    /// </summary>
    public RejectionReason47? NumberOfTransactionsRejected { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _j8wpt64cEemB_csI4yyKLA
    
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
        writer.WriteStartElement(null, "TtlNbOfTxs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(TotalNumberOfTransactions)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlNbOfTxsAccptd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(TotalNumberOfTransactionsAccepted)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlNbOfTxsRjctd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(TotalNumberOfTransactionsRejected)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        // Not sure how to serialize NumberOfTransactionsRejected, multiplicity Unknown
    }
    public static DetailedTransactionStatistics10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
