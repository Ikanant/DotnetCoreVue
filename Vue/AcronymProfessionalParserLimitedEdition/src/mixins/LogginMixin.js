export const loggingMixin = {
  computed: {
    componentName() {
      return `${this.$options.name} component`;
    }
  },
  created() {
    var componentName = this.componentName;
    console.log(`I just got created ${componentName}`);
  }
}
