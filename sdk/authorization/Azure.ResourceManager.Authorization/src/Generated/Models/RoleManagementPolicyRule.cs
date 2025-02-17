// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary>
    /// The role management policy rule.
    /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
    /// </summary>
    public partial class RoleManagementPolicyRule
    {
        /// <summary> Initializes a new instance of RoleManagementPolicyRule. </summary>
        public RoleManagementPolicyRule()
        {
        }

        /// <summary> Initializes a new instance of RoleManagementPolicyRule. </summary>
        /// <param name="id"> The id of the rule. </param>
        /// <param name="ruleType"> The type of rule. </param>
        /// <param name="target"> The target of the current rule. </param>
        internal RoleManagementPolicyRule(ResourceIdentifier id, RoleManagementPolicyRuleType ruleType, RoleManagementPolicyRuleTarget target)
        {
            Id = id;
            RuleType = ruleType;
            Target = target;
        }

        /// <summary> The id of the rule. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The type of rule. </summary>
        internal RoleManagementPolicyRuleType RuleType { get; set; }
        /// <summary> The target of the current rule. </summary>
        public RoleManagementPolicyRuleTarget Target { get; set; }
    }
}
