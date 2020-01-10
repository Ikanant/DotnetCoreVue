<template>
  <div class="container-fluid mt-4">
    <h1 class="h1">Search By Word</h1>
    <b-alert :show="loading" variant="info">Loading...</b-alert>
    <template>
      <div>
        <b-form-tags
          v-model="value"
          tag-variant="primary"
          tag-pills
          size="lg"
          separator=" "
          placeholder="Enter new ACRONYMS separated by space"
          class="mb-2"
        ></b-form-tags>
      </div>
    </template>
    <b-row>
      <b-col>
        <table class="table table-striped">
          <thead>
            <tr>
              <th>Name</th>
              <th>Value</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="record in records" :key="record.id">
              <td>{{ record.name }}</td>
              <td>{{ record.value }}</td>
            </tr>
          </tbody>
        </table>
      </b-col>
    </b-row>
  </div>
</template>

<script>
  import api from '@/services/AcronymRecordsApiService';

  export default {
    data() {
      return {
        loading: false,
        records: [],
        model: {},
        value: []
      };
    },
    async created() {
      this.getAll()
    },
    methods: {
      async getAll() {
        console.log("searching");
        this.loading = true

        try {
          this.records = await api.getAll()
        } finally {
          this.loading = false
        }
      },
      async updateAcronymRecord(acronymRecord) {
        // We use Object.assign() to create a new (separate) instance
        this.model = Object.assign({}, acronymRecord)
      },
      async createAcronymRecord() {
        const isUpdate = !!this.model.id;

        if (isUpdate) {
          await api.update(this.model.id, this.model)
        } else {
          await api.create(this.model)
        }

        // Clear the data inside of the form
        this.model = {}

        // Fetch all records again to have latest data
        await this.getAll()
      },
      async deleteAcronymRecord(id) {
        if (confirm('Are you sure you want to delete this record?')) {
          // if we are editing a acronym record we deleted, remove it from the form
          if (this.model.id === id) {
            this.model = {}
          }

          await api.delete(id)
          await this.getAll()
        }
      }
    }
  }
</script>
