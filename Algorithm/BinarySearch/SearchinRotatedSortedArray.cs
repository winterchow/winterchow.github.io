public int Search(int[] nums, int target) {
    int start = 0, end = nums.Length - 1;
    while(start <= end){
        int mid = (start + end) / 2;
        if(nums[mid] == target){
            return mid;
        }
        if(nums[mid] >= nums[start]){ //左边有序
            if(target < nums[mid] && target >= nums[start]){ 
                end  = mid - 1;
            }
            else{
                start = mid + 1;
            }
        }
        else{ // 右边有序
            if(target > nums[mid] && target <= nums[end]){
                start = mid + 1;
            }
            else{
                end = mid - 1;
            }
        }
    }   

    return -1;     
}