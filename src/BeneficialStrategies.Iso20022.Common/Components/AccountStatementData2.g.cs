﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatementData2.  ISO2002 ID# _mIue8TaqEeyjpIf0r_Ojqw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
public partial record AccountStatementData2
     : IIsoXmlSerilizable<AccountStatementData2>
{
    #nullable enable
    
    /// <summary>
    /// Date the statement is generated.
    /// </summary>
    public IsoISODate? StatementDate { get; init; } 
    /// <summary>
    /// Time the account statement is generated.
    /// </summary>
    public IsoISOTime? StatementTime { get; init; } 
    /// <summary>
    /// Statement information.
    /// </summary>
    public AccountStatementDetails2? AccountStatement { get; init; } 
    
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
        if (StatementDate is IsoISODate StatementDateValue)
        {
            writer.WriteStartElement(null, "StmtDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(StatementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (StatementTime is IsoISOTime StatementTimeValue)
        {
            writer.WriteStartElement(null, "StmtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISOTime(StatementTimeValue)); // data type ISOTime System.TimeOnly
            writer.WriteEndElement();
        }
        if (AccountStatement is AccountStatementDetails2 AccountStatementValue)
        {
            writer.WriteStartElement(null, "AcctStmt", xmlNamespace );
            AccountStatementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountStatementData2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
