# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
library-name: Monitor
namespace: Azure.ResourceManager.Monitor
require: https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/readme.md
output-folder: $(this-folder)/Generated
tag: package-monitor-track2
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

format-by-name-rules:
  'tenantId': 'uuid'
  'ETag': 'etag'
  'location': 'azure-location'
  'locations': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'
  'ResourceId': 'arm-id'
  'TargetResourceId': 'arm-id'
  'TargetResourceLocation': 'azure-location'
  'StorageAccountId': 'arm-id'
  'ServiceBusRuleId': 'arm-id'
  'EventHubAuthorizationRuleId': 'arm-id'
  'WorkspaceResourceId': 'arm-id'
  'MetricResourceId': 'arm-id'
  'MetricResourceLocation': 'azure-location'
  'DataCollectionRuleId': 'arm-id'
  'DataCollectionEndpointId': 'arm-id'
  'MarketplacePartnerId': 'arm-id'

rename-rules:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs|ips
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4|ipv4
  Ipv6: IPv6|ipv6
  Ipsec: IPsec|ipsec
  SSO: Sso
  URI: Uri
  Etag: ETag|etag
  Odatatype: OdataType

irregular-plural-words:
  status: status

prepend-rp-prefix:
- Action
- Recurrence
- Operator
- Response
- OdataType
- Metric
- Incident
- Enabled
- Dimension
- Schedule
- Criteria
- Source
- OperationType

override-operation-name:
  ActionGroups_GetTestNotifications: GetNotificationStatus
  ActionGroups_PostTestNotifications: CreateNotifications
  ActionGroups_CreateNotificationsAtResourceGroupLevel: CreateNotifications
  ActionGroups_CreateNotificationsAtActionGroupResourceLevel: CreateNotifications

rename-mapping:
  MetricTrigger.metricResourceUri: metricResourceId
  AutoscaleSetting: AutoscaleSettingProperties
  AutoscaleSettingResource: AutoscaleSetting
  AutoscaleSettingResource.properties.targetResourceUri: targetResourceId
  AutoscaleSettingResource.properties.enabled: IsEnabled
  AutoscaleSettingResource.properties.name: AutoscaleSettingName
  AutoscaleSettingResourcePatch.properties.targetResourceUri: targetResourceId
  AutoscaleSettingResourcePatch.properties.enabled: IsEnabled
  AutoscaleSettingResourcePatch.properties.name: AutoscaleSettingName
  AzureMonitorPrivateLinkScope: PrivateLinkScope
  ScopedResource: PrivateLinkScopedResource
  DataCollectionRuleAssociation: DataCollectionRuleAssociationProperties
  DataCollectionRuleAssociationProxyOnlyResource: DataCollectionRuleAssociation
  ActionGroup: ActionGroupProperties
  ActionGroupResource: ActionGroup
  ActionGroupResource.properties.enabled: IsEnabled
  MetricAlertResource: MetricAlert
  DiagnosticSettings: DiagnosticSettingsProperties
  DiagnosticSettingsResource: DiagnosticSettings
  ActivityLogAlert: ActivityLogAlertProperties
  ActivityLogAlertResource: ActivityLogAlert
  ActivityLogAlertResource.properties.enabled: IsEnabled
  ActivityLogAlertResourcePatch.properties.enabled: IsEnabled
  AlertRule: AlertRuleProperties
  AlertRuleResource: AlertRule
  AlertRuleResource.properties.name: AlertRuleName
  DataCollectionEndpoint: DataCollectionEndpointProperties
  DataCollectionEndpointResource: DataCollectionEndpoint
  DataCollectionRule: DataCollectionRuleProperties
  DataCollectionRuleResource: DataCollectionRule
  DiagnosticSettingsCategory: DiagnosticSettingsCategoryProperties
  DiagnosticSettingsCategoryResource: DiagnosticSettingsCategory
  LogProfileResource: LogProfile
  LogSearchRule: LogSearchRuleProperties
  LogSearchRuleResource: LogSearchRule
  RuleDataSource.resourceUri: resourceId
  RuleMetricDataSource.resourceUri: resourceId
  RuleManagementEventDataSource.resourceUri: resourceId
  LogSearchRule.autoMitigate: IsAutoMitigate
  MetricAlertResource.properties.autoMitigate: IsAutoMitigate
  MetricAlertResource.properties.enabled: IsEnabled
  MetricAlertResourcePatch.properties.autoMitigate: IsAutoMitigate
  MetricAlertResourcePatch.properties.enabled: IsEnabled
  MetricSettings.enabled: IsEnabled
  EventData: EventDataInfo
  LogSettings.enabled: IsEnabled
  RetentionPolicy.enabled: IsEnabled
  TimeWindow.start: StartOn
  TimeWindow.end: EndOn
  AlertRuleAnyOfOrLeafCondition: ActivityLogAlertAnyOfOrLeafCondition
  RuleAction: AlertRuleAction
  RuleCondition: AlertRuleCondition
  KnownPublicNetworkAccessOptions: MonitorPublicNetworkAccess
  KnownDataCollectionEndpointProvisioningState: DataCollectionEndpointProvisioningState
  KnownDataCollectionRuleAssociationProvisioningState: DataCollectionRuleAssociationProvisioningState
  KnownDataCollectionRuleProvisioningState: DataCollectionRuleProvisioningState
  ProvisioningState: MonitorProvisioningState
  KnownDataFlowStreams: DataFlowStreams
  KnownExtensionDataSourceStreams: ExtensionDataSourceStreams
  KnownPerfCounterDataSourceStreams: PerfCounterDataSourceStreams
  KnownSyslogDataSourceFacilityNames: SyslogDataSourceFacilityNames
  KnownSyslogDataSourceLogLevels: SyslogDataSourceLogLevels
  KnownSyslogDataSourceStreams: SyslogDataSourceStreams
  KnownWindowsEventLogDataSourceStreams: WindowsEventLogDataSourceStreams
  LocalizableString: MonitorLocalizableString
  MetricTrigger.dividePerInstance: IsDividedPerInstance
  AggregationTypeEnum: MonitorAggregationType
  NotificationRequestBody: NotificationContent
  Context: NotificationContext
  TestNotificationDetailsResponse: NotificationStatus
  ActionDetail: NotificationActionDetail
  TimeWindow: MonitorTimeWindow
  ArmRoleReceiver: MonitorArmRoleReceiver
  AutomationRunbookReceiver: MonitorAutomationRunbookReceiver
  AzureAppPushReceiver: MonitorAzureAppPushReceiver
  AzureFunctionReceiver: MonitorAzureFunctionReceiver
  EmailReceiver: MonitorEmailReceiver
  EventHubReceiver: MonitorEventHubReceiver
  ItsmReceiver: MonitorItsmReceiver
  LogicAppReceiver: MonitorLogicAppReceiver
  SmsReceiver: MonitorSmsReceiver
  VoiceReceiver: MonitorVoiceReceiver
  WebhookReceiver: MonitorWebhookReceiver
  WorkspaceInfo: DataContainerWorkspace
  CategoryType: MonitorCategoryType
  ConditionOperator: MonitorConditionOperator
  EventLevel: MonitorEventLevel
  ScaleAction: MonitorScaleAction
  ScaleDirection: MonitorScaleDirection
  ScaleType: MonitorScaleType
  ScaleCapacity: MonitorScaleCapacity
  TimeAggregationOperator: MonitorTimeAggregationOperator
  TimeAggregationType: MonitorTimeAggregationType
  ReceiverStatus: MonitorReceiverStatus
  EnableRequest: ActionGroupEnableContent
  OperationStatus: MonitorPrivateLinkScopeOperationStatus
  QueryType: MonitorSourceQueryType

directive:
  # nullable issue resolution
  - from: swagger-document
    where: $.definitions.ActivityLogAlert.properties.actions
    transform: $["x-nullable"] = true;
  - from: swagger-document
    where: $.definitions.MetricAlertProperties.properties.criteria
    transform: $["x-nullable"] = true;
  - from: swagger-document
    where: $.definitions.MetricTrigger.properties.dimensions
    transform: $["x-nullable"] = true;
  - from: swagger-document
    where: $.definitions.AutoscaleSetting.properties.notifications
    transform: $["x-nullable"] = true;
  - from: swagger-document
    where: $.definitions.LogProfileProperties.properties.storageAccountId
    transform: $["x-nullable"] = true;
  - from: swagger-document
    where: $.definitions.LogProfileProperties.properties.serviceBusRuleId
    transform: $["x-nullable"] = true;
  - from: swagger-document
    where: $.definitions.AutoscaleSetting.properties.predictiveAutoscalePolicy
    transform: $["x-nullable"] = true;
  # duplicate schema resolution
  - from: activityLogAlerts_API.json
    where: $.definitions.AzureResource
    transform: $["x-ms-client-name"] = "ActivityLogAlertsResource"
  - from: activityLogAlerts_API.json
    where: $.definitions.ActionGroup
    transform: $["x-ms-client-name"] = "ActivityLogAlertActionGroup"
  - from: activityLogAlerts_API.json
    where: $.definitions.ErrorResponse
    transform: $["x-ms-client-name"] = "ActivityLogAlertErrorResponse"
  - from: scheduledQueryRule_API.json
    where: $.definitions.Resource
    transform: $["x-ms-client-name"] = "ScheduledQueryRuleResource"
  - from: autoscale_API.json
    where: $.definitions.Resource
    transform: $["x-ms-client-name"] = "AutoScaleResource"
  - from: types.json
    where: $.definitions.Resource
    transform: $["x-ms-client-name"] = "CommonResource"
  - from: types.json
    where: $.definitions.ProxyResource
    transform: $["x-ms-client-name"] = "CommonProxyResource"
  # some format changes
  - from: swagger-document
    where: $.definitions.DiagnosticSettings.properties.workspaceId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.ScopedResourceProperties.properties.linkedResourceId
    transform: $["x-ms-format"] = "arm-id"
  - from: activityLogAlerts_API.json
    where: $.definitions.ActionGroup.properties.actionGroupId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.AutomationRunbookReceiver.properties.automationAccountId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.AutomationRunbookReceiver.properties.webhookResourceId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.AzureFunctionReceiver.properties.functionAppResourceId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.MetricAlertAction.properties.actionGroupId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.Source.properties.dataSourceId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.WebtestLocationAvailabilityCriteria.properties.webTestId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.WebtestLocationAvailabilityCriteria.properties.componentId
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.WorkspaceInfo.properties.id
    transform: $["x-ms-format"] = "arm-id"
  - from: swagger-document
    where: $.definitions.PrivateLinkResourceProperties.properties.groupId
    transform: $["x-ms-format"] = "arm-id"
  # in order to let the ResponseError replace the ErrorResponseCommon in monitor, we need to add a target property to it
  - from: swagger-document
    where: $.definitions.ErrorResponseCommon.properties
    transform: >
      $["target"] = {
        "readOnly": true,
        "type": "string"
      }
  # remove unnecessary property for resources in action groups. Both of these are not used, and identity has an incorrect type.
  - from: scheduledQueryRule_API.json
    where: $.definitions.Resource.properties
    transform: >
      $["kind"] = undefined;
  - from: dataCollectionEndpoints_API.json
    where: $.definitions.DataCollectionEndpointResource.properties
    transform: >
      $["kind"] = undefined;
  - from: dataCollectionRules_API.json
    where: $.definitions.DataCollectionRuleResource.properties
    transform: >
      $["kind"] = undefined;
```

## Tag: package-monitor-track2

Introduce this tag because the new tag in monitor reverted something in monitor back to preview

These settings apply only when `--tag=package-monitor-track2` is specified on the command line.

```yaml $(tag) == 'package-monitor-track2'
input-file:
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2022-10-01/autoscale_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2015-04-01/operations_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/alertRulesIncidents_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/alertRules_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2016-03-01/logProfiles_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/preview/2021-05-01-preview/diagnosticsSettings_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/preview/2021-05-01-preview/diagnosticsSettingsCategories_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/actionGroups_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2015-04-01/activityLogs_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2015-04-01/eventCategories_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2015-04-01/tenantActivityLogs_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2018-01-01/metricDefinitions_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2018-01-01/metrics_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2019-03-01/metricBaselines_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2018-03-01/metricAlert_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2018-04-16/scheduledQueryRule_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/preview/2017-12-01-preview/metricNamespaces_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/preview/2018-11-27-preview/vmInsightsOnboarding_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/preview/2021-07-01-preview/privateLinkScopes_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2020-10-01/activityLogAlerts_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2021-04-01/dataCollectionEndpoints_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2021-04-01/dataCollectionRuleAssociations_API.json
- https://github.com/Azure/azure-rest-api-specs/blob/37966a6de2451407408adc2da5ab25631f0dd9b9/specification/monitor/resource-manager/Microsoft.Insights/stable/2021-04-01/dataCollectionRules_API.json
```
