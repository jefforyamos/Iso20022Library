﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RetailerReversalResult3.  ISO2002 ID# _b6qjIS84Eeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal transaction results after a Reversal request.
/// </summary>
public partial record RetailerReversalResult3
     : IIsoXmlSerilizable<RetailerReversalResult3>
{
    #nullable enable
    
    /// <summary>
    /// POI reconciliation identification.
    /// </summary>
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    /// <summary>
    /// Original Transaction if any linked to this reversal.
    /// </summary>
    public CardPaymentTransaction110? OriginalPaymentTransaction { get; init; } 
    /// <summary>
    /// Updated Customer order list after reversal.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init; } 
    
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
        if (POIReconciliationIdentification is IsoMax35Text POIReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "POIRcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(POIReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalPaymentTransaction is CardPaymentTransaction110 OriginalPaymentTransactionValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtTx", xmlNamespace );
            OriginalPaymentTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CustomerOrder is CustomerOrder1 CustomerOrderValue)
        {
            writer.WriteStartElement(null, "CstmrOrdr", xmlNamespace );
            CustomerOrderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RetailerReversalResult3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
