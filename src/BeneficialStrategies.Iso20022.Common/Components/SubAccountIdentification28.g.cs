﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification28.  ISO2002 ID# _mh1foQ0qEeK9as54HthO0w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SubAccountIdentification28
     : IIsoXmlSerilizable<SubAccountIdentification28>
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount14 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    public AggregateBalanceInformation21? BalanceForSubAccount { get; init; } 
    
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
        if (AccountOwner is PartyIdentification36Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ActvtyInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ActivityIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (BalanceForSubAccount is AggregateBalanceInformation21 BalanceForSubAccountValue)
        {
            writer.WriteStartElement(null, "BalForSubAcct", xmlNamespace );
            BalanceForSubAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubAccountIdentification28 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
