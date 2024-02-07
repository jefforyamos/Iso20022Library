﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatementGroup1.  ISO2002 ID# _6QsqlZqlEeGSON8vddiWzQ_1977241265.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of the statement header reporting the bank services billing and the billing statement.
/// </summary>
public partial record StatementGroup1
     : IIsoXmlSerilizable<StatementGroup1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a group of customer billing statements.
    /// </summary>
    public required IsoMax35Text GroupIdentification { get; init; } 
    /// <summary>
    /// Originating financial institution sending the statement.
    /// </summary>
    public required PartyIdentification58 Sender { get; init; } 
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the sender's location.
    /// </summary>
    public ValueList<ContactDetails3> SenderIndividualContact { get; init; } = [];
    /// <summary>
    /// Financial institution customer receiving the statement.
    /// </summary>
    public required PartyIdentification58 Receiver { get; init; } 
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the receiver's location.
    /// </summary>
    public ValueList<ContactDetails3> ReceiverIndividualContact { get; init; } = [];
    /// <summary>
    /// Provides the bank services billing statement recounting of all service chargeable events that occurred during a reporting cycle, such as the end of the month reporting.
    /// </summary>
    public BillingStatement1? BillingStatement { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _6Q10gpqlEeGSON8vddiWzQ_-1643820345
    
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
        writer.WriteStartElement(null, "GrpId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(GroupIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sndr", xmlNamespace );
        Sender.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SndrIndvCtct", xmlNamespace );
        SenderIndividualContact.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rcvr", xmlNamespace );
        Receiver.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RcvrIndvCtct", xmlNamespace );
        ReceiverIndividualContact.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize BillingStatement, multiplicity Unknown
    }
    public static StatementGroup1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
