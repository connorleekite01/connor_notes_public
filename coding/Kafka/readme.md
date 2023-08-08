# Kafka Cloud with terraform

[Kafka Cloud Terraform Provider document and sample Link](https://registry.terraform.io/providers/confluentinc/confluentcloud/latest/docs)

[Kafka Cloud Terraform Provider GitHub Link](https://github.com/confluentinc/terraform-provider-confluent)

https://portal.azure.com/#view/HubsExtension/DeploymentDetailsBlade/~/overview/id/%2Fsubscriptions%2Facfb5c95-6f5b-41ff-b4e3-ede1e346d10e%2FresourceGroups%2Fconnor_testing%2Fproviders%2FMicrosoft.Resources%2Fdeployments%2Fconfluentinc.confluent-cloud-azure-prod/packageId/confluentinc.confluent-cloud-azure-prod/packageIconUri/https%3A%2F%2Fstore-images.s-microsoft.com%2Fimage%2Fapps.16180.f062ab11-0ea4-4176-aa84-833168f9e362.a55ef15c-0860-4da5-ade2-b62a6e932543.6c2c698d-4450-4941-868d-a66c00a0e318/primaryResourceId/%2Fsubscriptions%2Facfb5c95-6f5b-41ff-b4e3-ede1e346d10e%2Fresourcegroups%2Fconnor_testing%2Fproviders%2FMicrosoft.Confluent%2Forganizations%2Fconnor-testing/createBlade~/%7B%22bladeName%22%3A%22CreateBlade%22%2C%22extension%22%3A%22Azure_Marketplace_Confluent%22%2C%22telemetryId%22%3A%227190fd3e-3d75-48d2-b6e4-76a8a0c91e26%22%7D


```bash
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ terraform plan -out=tfplan_add_sa_env_and_cluster
module.confluent_kafka_topics.confluent_kafka_topic.main["clicks"]: Refreshing state... [id=lkc-q8w556/clicks]
module.confluent_kafka_topics.confluent_kafka_topic.main["players"]: Refreshing state... [id=lkc-q8w556/players]
module.confluent_kafka_topics.confluent_kafka_topic.main["orders"]: Refreshing state... [id=lkc-q8w556/orders]

No changes. Your infrastructure matches the configuration.

Terraform has compared your real infrastructure against your configuration and found no differences, so no changes are needed.
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ terraform plan -out=tfplan_add_sa_env_and_cluster
module.confluent_kafka_topics.confluent_kafka_topic.main["orders"]: Refreshing state... [id=lkc-q8w556/orders]
module.confluent_kafka_topics.confluent_kafka_topic.main["players"]: Refreshing state... [id=lkc-q8w556/players]
module.confluent_kafka_topics.confluent_kafka_topic.main["clicks"]: Refreshing state... [id=lkc-q8w556/clicks]

Terraform used the selected providers to generate the following execution plan. Resource actions are indicated with the following
symbols:
  + create

Terraform will perform the following actions:

  # module.confluent_kafka_topics.confluent_kafka_topic.main["connor_testing"] will be created
  + resource "confluent_kafka_topic" "main" {
      + config           = {
          + "cleanup.policy" = "compact"
          + "retention.ms"   = "604800000"
        }
      + id               = (known after apply)
      + partitions_count = 6
      + topic_name       = "connor_testing"
    }

Plan: 1 to add, 0 to change, 0 to destroy.

Changes to Outputs:
  ~ created_kafka_topics = {
      + connor_testing = {
          + config           = {
              + "cleanup.policy" = "compact"
              + "retention.ms"   = "604800000"
            }
          + credentials      = []
          + id               = (known after apply)
          + kafka_cluster    = []
          + partitions_count = 6
          + rest_endpoint    = null
          + topic_name       = "connor_testing"
        }
        # (3 unchanged attributes hidden)
    }

────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

Saved the plan to: tfplan_add_sa_env_and_cluster

To perform exactly these actions, run the following command to apply:
    terraform apply "tfplan_add_sa_env_and_cluster"
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ terraform apply "tfplan_add_sa_env_and_cluster"
module.confluent_kafka_topics.confluent_kafka_topic.main["connor_testing"]: Creating...
╷
│ Error: error creating Kafka Topic: 400 Bad Request: Topic 'connor_testing' already exists.
│ 
│   with module.confluent_kafka_topics.confluent_kafka_topic.main["connor_testing"],
│   on confluent_kafka_topics_module/main.tf line 20, in resource "confluent_kafka_topic" "main":
│   20: resource "confluent_kafka_topic" "main" {
│ 
╵
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ terraform plan -out=tfplan_add_sa_env_and_cluster
module.confluent_kafka_topics.confluent_kafka_topic.main["players"]: Refreshing state... [id=lkc-q8w556/players]
module.confluent_kafka_topics.confluent_kafka_topic.main["clicks"]: Refreshing state... [id=lkc-q8w556/clicks]
module.confluent_kafka_topics.confluent_kafka_topic.main["orders"]: Refreshing state... [id=lkc-q8w556/orders]

No changes. Your infrastructure matches the configuration.

Terraform has compared your real infrastructure against your configuration and found no differences, so no changes are needed.
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ terraform apply "tfplan_add_sa_env_and_cluster"

Apply complete! Resources: 0 added, 0 changed, 0 destroyed.

Outputs:

created_kafka_topics = {
  "clicks" = {
    "config" = tomap({})
    "credentials" = tolist([])
    "id" = "lkc-q8w556/clicks"
    "kafka_cluster" = tolist([])
    "partitions_count" = 6
    "rest_endpoint" = tostring(null)
    "topic_name" = "clicks"
  }
  "orders" = {
    "config" = tomap({
      "cleanup.policy" = "delete"
      "retention.ms" = "259200000"
    })
    "credentials" = tolist([])
    "id" = "lkc-q8w556/orders"
    "kafka_cluster" = tolist([])
    "partitions_count" = 6
    "rest_endpoint" = tostring(null)
    "topic_name" = "orders"
  }
  "players" = {
    "config" = tomap({
      "cleanup.policy" = "compact"
      "retention.ms" = "604800000"
    })
    "credentials" = tolist([])
    "id" = "lkc-q8w556/players"
    "kafka_cluster" = tolist([])
    "partitions_count" = 3
    "rest_endpoint" = tostring(null)
    "topic_name" = "players"
  }
}
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ terraform plan -out=tfplan_add_sa_env_and_cluster
module.confluent_kafka_topics.confluent_kafka_topic.main["orders"]: Refreshing state... [id=lkc-q8w556/orders]
module.confluent_kafka_topics.confluent_kafka_topic.main["players"]: Refreshing state... [id=lkc-q8w556/players]
module.confluent_kafka_topics.confluent_kafka_topic.main["clicks"]: Refreshing state... [id=lkc-q8w556/clicks]

Terraform used the selected providers to generate the following execution plan. Resource actions are indicated with the following
symbols:
  + create

Terraform will perform the following actions:

  # module.confluent_kafka_topics.confluent_kafka_topic.main["connor_testing"] will be created
  + resource "confluent_kafka_topic" "main" {
      + config           = {
          + "cleanup.policy" = "compact"
          + "retention.ms"   = "604800000"
        }
      + id               = (known after apply)
      + partitions_count = 3
      + topic_name       = "connor_testing"
    }

Plan: 1 to add, 0 to change, 0 to destroy.

Changes to Outputs:
  ~ created_kafka_topics = {
      + connor_testing = {
          + config           = {
              + "cleanup.policy" = "compact"
              + "retention.ms"   = "604800000"
            }
          + credentials      = []
          + id               = (known after apply)
          + kafka_cluster    = []
          + partitions_count = 3
          + rest_endpoint    = null
          + topic_name       = "connor_testing"
        }
        # (3 unchanged attributes hidden)
    }

────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

Saved the plan to: tfplan_add_sa_env_and_cluster

To perform exactly these actions, run the following command to apply:
    terraform apply "tfplan_add_sa_env_and_cluster"
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ terraform apply "tfplan_add_sa_env_and_cluster"
module.confluent_kafka_topics.confluent_kafka_topic.main["connor_testing"]: Creating...
module.confluent_kafka_topics.confluent_kafka_topic.main["connor_testing"]: Still creating... [10s elapsed]
module.confluent_kafka_topics.confluent_kafka_topic.main["connor_testing"]: Creation complete after 11s [id=lkc-q8w556/connor_testing]

Apply complete! Resources: 1 added, 0 changed, 0 destroyed.

Outputs:

created_kafka_topics = {
  "clicks" = {
    "config" = tomap({})
    "credentials" = tolist([])
    "id" = "lkc-q8w556/clicks"
    "kafka_cluster" = tolist([])
    "partitions_count" = 6
    "rest_endpoint" = tostring(null)
    "topic_name" = "clicks"
  }
  "connor_testing" = {
    "config" = tomap({
      "cleanup.policy" = "compact"
      "retention.ms" = "604800000"
    })
    "credentials" = tolist([])
    "id" = "lkc-q8w556/connor_testing"
    "kafka_cluster" = tolist([])
    "partitions_count" = 3
    "rest_endpoint" = tostring(null)
    "topic_name" = "connor_testing"
  }
  "orders" = {
    "config" = tomap({
      "cleanup.policy" = "delete"
      "retention.ms" = "259200000"
    })
    "credentials" = tolist([])
    "id" = "lkc-q8w556/orders"
    "kafka_cluster" = tolist([])
    "partitions_count" = 6
    "rest_endpoint" = tostring(null)
    "topic_name" = "orders"
  }
  "players" = {
    "config" = tomap({
      "cleanup.policy" = "compact"
      "retention.ms" = "604800000"
    })
    "credentials" = tolist([])
    "id" = "lkc-q8w556/players"
    "kafka_cluster" = tolist([])
    "partitions_count" = 3
    "rest_endpoint" = tostring(null)
    "topic_name" = "players"
  }
}
litian9@DESKTOP-FANTOM5:~/projects/connor_notes_public/coding/Kafka/terraform-provider-confluent/examples/configurations/manage-topics-via-json$ 
```