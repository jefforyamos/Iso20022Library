﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HeadMemberDetails.  ISO2002 ID# _zpIWcCDsEeav65mEytrgaA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.LiquidityPoolMembers1Choice;

/// <summary>
/// Information about head member of liquidity pool.
/// </summary>
public partial record HeadMemberDetails : LiquidityPoolMembers1Choice_
     , IIsoXmlSerilizable<HeadMemberDetails>
{
    #nullable enable
    
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required CashAccount24 Account { get; init; } 
    /// <summary>
    /// Account owner identification.
    /// </summary>
    public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Acct", xmlNamespace );
        Account.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
        AccountOwner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new HeadMemberDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
