(function () {
   const alertElement = document.getElementById("success-alert");
   const formElement = document.forms[0];

   const addNewItem = async () => {
      const formData = new FormData(document.getElementById('form'))

      formData.forEach((key, value) => {
         data[value] = value[key];
      });

      const requestData = {
         method: 'POST',
         body: JSON.stringify(data)
      };

      const responseFetch = await fetch('/api/CompanyAjax', requestData);

      const response = await responseFetch.json();
      if (response.success) {
         alertElement.style.display = 'block';
      }
   };
   window.addEventListener("load", () => {
      formElement.addEventListener("submit", event => {
         event.preventDefault(); addNewItem().then(() => console.log("added successfully"));
   });
})();