<template>
  <div>
    <h3>Bad implementation of a component</h3<>
    <table class="table table-striped">
      <thead>
        <tr>
          <th>Name</th>
          <th>Value</th>
          <th>Description</th>
          <th>&nbsp;</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="record in records" :key="record.id">
          <td>{{ record.name | capitalized}}</td>
          <td>{{ record.value }}</td>
          <td>{{ record.description }}</td>
          <td class="text-right">
            <a href="#" @click.prevent="updateAcronymRecord(record)">Edit</a> -
            <a href="#" @click.prevent="deleteAcronymRecord(record.id)">Delete</a>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import api from "@/services/AcronymRecordsApiService";
import { loggingMixin } from "@/mixins/LogginMixin";

export default {
  data() {
    return {
      componentName: "Acronym Editor Record Table"
    };
  },
  mixins: [loggingMixin],
  created() {
    console.log("component created method");
  },
  props: {
    records: {
      type: Array,
      default: []
    }
  },
  methods: {
    updateAcronymRecord(record) {
      // This is BAD... we are essentially changing the property directly
      // This will affect the parent component as well
      record.name = record.name + record.name;
    },
    deleteAcronymRecord(recordId) {
      this.$emit("deleteAcronymRecord", recordId);
    }
  },
  filters: {
    capitalized: function(value) {
      if (!value) return "";

      return value.toUpperCase();
    }
  }
};
</script>
