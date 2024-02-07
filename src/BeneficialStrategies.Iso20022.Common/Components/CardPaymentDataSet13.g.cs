﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet13.  ISO2002 ID# _ozFJQY3IEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of transactions to capture, sharing common characteristics.
/// </summary>
public partial record CardPaymentDataSet13
     : IIsoXmlSerilizable<CardPaymentDataSet13>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    public Traceability5? Traceability { get; init; } 
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    public GenericIdentification53? DataSetInitiator { get; init; } 
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    public TransactionTotals7? TransactionTotals { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _o988h43IEeWjkqXgn_0Imw
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    public CommonData5? CommonData { get; init; } 
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    public CardPaymentDataSetTransaction4Choice_? Transaction { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _o988i43IEeWjkqXgn_0Imw
    
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
        writer.WriteStartElement(null, "DataSetId", xmlNamespace );
        DataSetIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Traceability is Traceability5 TraceabilityValue)
        {
            writer.WriteStartElement(null, "Tracblt", xmlNamespace );
            TraceabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DataSetInitiator is GenericIdentification53 DataSetInitiatorValue)
        {
            writer.WriteStartElement(null, "DataSetInitr", xmlNamespace );
            DataSetInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize TransactionTotals, multiplicity Unknown
        if (CommonData is CommonData5 CommonDataValue)
        {
            writer.WriteStartElement(null, "CmonData", xmlNamespace );
            CommonDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize Transaction, multiplicity Unknown
    }
    public static CardPaymentDataSet13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
