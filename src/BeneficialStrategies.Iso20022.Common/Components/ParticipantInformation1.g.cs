﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ParticipantInformation1.  ISO2002 ID# _5On4EB9nEeapDZRA0Hb6ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Participant profile participant information.
/// </summary>
public partial record ParticipantInformation1
     : IIsoXmlSerilizable<ParticipantInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Date the profile was deleted.
    /// </summary>
    public IsoISODateTime? ProfileDeletionDate { get; init; } 
    /// <summary>
    /// National BIC identifiers for authorised and central branches.
    /// </summary>
    public CentralisedAndAuthorisedBranchIdentification1Choice_? BankBranch { get; init; } 
    /// <summary>
    /// CBRF identification of the terminal.
    /// </summary>
    public IsoMax35Text? TerminalIdentification { get; init; } 
    /// <summary>
    /// Intraday restrictions details.
    /// </summary>
    public IsoMax35Text? Restrictions { get; init; } 
    /// <summary>
    /// External payment system details.
    /// </summary>
    public ExternalPaymentSystemDetails1? ExternalPaymentSystemInformation { get; init; } 
    /// <summary>
    /// Information related for participant migration process.
    /// </summary>
    public required SystemMigration1 Migration { get; init; } 
    
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
        if (ProfileDeletionDate is IsoISODateTime ProfileDeletionDateValue)
        {
            writer.WriteStartElement(null, "PrflDeltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ProfileDeletionDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (BankBranch is CentralisedAndAuthorisedBranchIdentification1Choice_ BankBranchValue)
        {
            writer.WriteStartElement(null, "BkBrnch", xmlNamespace );
            BankBranchValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminalIdentification is IsoMax35Text TerminalIdentificationValue)
        {
            writer.WriteStartElement(null, "TermnlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TerminalIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Restrictions is IsoMax35Text RestrictionsValue)
        {
            writer.WriteStartElement(null, "Rstrctns", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RestrictionsValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ExternalPaymentSystemInformation is ExternalPaymentSystemDetails1 ExternalPaymentSystemInformationValue)
        {
            writer.WriteStartElement(null, "XtrnlPmtSysInf", xmlNamespace );
            ExternalPaymentSystemInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Mgrtn", xmlNamespace );
        Migration.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ParticipantInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
