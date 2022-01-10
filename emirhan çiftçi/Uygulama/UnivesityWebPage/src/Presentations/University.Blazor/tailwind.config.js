const colors = require('tailwindcss/colors');
module.exports = {
  content: ['./**/*.{html,razor}'],
  darkMode: 'media',
  theme: {
    extend: {
      colors:{
            'custom-gray': '#32445a',
            info: '#1f9fcc'
      },
      spacing:{'15': '3.75rem'}
    },
  },
  variants: {
    extend: {},
  },
  plugins: [
  ]
}